using System.Collections;
using UnityEngine;

public class PlantGrowth : MonoBehaviour
{
    [Header("Configuración de Crecimiento")]
    public Vector3 matureSize = new Vector3(1f, 1f, 1f);
    public Vector3 seedSize = new Vector3(0.1f, 0.1f, 0.1f);
    public float growthTime = 10f;

    [Header("Configuración de Estado")]
    public Material matureMaterial;
    public bool isMature { get; private set; }

    private Renderer plantRenderer;

    void Start()
    {
        plantRenderer = GetComponent<Renderer>();
        transform.localScale = seedSize;
        isMature = false;
        StartCoroutine(Grow());
    }

    private IEnumerator Grow()
    {
        float timer = 0f;
        while (timer < growthTime)
        {
            timer += Time.deltaTime;
            float growthRatio = timer / growthTime;
            transform.localScale = Vector3.Lerp(seedSize, matureSize, growthRatio);
            yield return null;
        }

        transform.localScale = matureSize;
        isMature = true;
        
        if (matureMaterial != null)
        {
            plantRenderer.material = matureMaterial;
        }
    }

    public void Harvest()
    {
        // --- LÍNEA MODIFICADA ---
        // Antes de destruir la planta, le decimos al InventoryManager que añada 1 de miel.
        // Gracias al Singleton, podemos acceder a él fácilmente desde cualquier sitio.
        InventoryManager.instance.AddHoney(1);

        // Ahora sí, destruimos la planta.
        Destroy(gameObject);
    }
}
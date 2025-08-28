using UnityEngine;

public class PlantingController : MonoBehaviour
{
    [Header("Configuración de Plantado")]
    public GameObject plantPrefab;
    public LayerMask plantingMask;

    private Camera mainCamera;
    private PlayerStats playerStats; // Referencia a nuestro nuevo script de estadísticas.

    void Start()
    {
        mainCamera = Camera.main;
        // Obtenemos el componente PlayerStats que está en el mismo objeto (el Jugador).
        playerStats = GetComponent<PlayerStats>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            TryPlant();
        }
    }

    private void TryPlant()
    {
        Ray ray = mainCamera.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2));
        RaycastHit hitInfo;

        // --- LÍNEA MODIFICADA ---
        // Ahora usamos la distancia de interacción desde nuestro script central PlayerStats.
        if (Physics.Raycast(ray, out hitInfo, playerStats.interactionDistance, plantingMask))
        {
            if (hitInfo.collider.CompareTag("Ground"))
            {
                PlantObject(hitInfo.point);
            }
        }
    }

    private void PlantObject(Vector3 position)
    {
        if (plantPrefab != null)
        {
            Instantiate(plantPrefab, position, Quaternion.identity);
        }
    }
}

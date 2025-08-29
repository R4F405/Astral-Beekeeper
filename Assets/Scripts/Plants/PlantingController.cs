using UnityEngine;

public class PlantingController : MonoBehaviour
{
    [Header("Configuración de Plantado")]
    public GameObject plantPrefab;
    public LayerMask plantingMask;
    public LayerMask obstacleMask;

    private Camera mainCamera;
    private PlayerStats playerStats;

    void Start()
    {
        mainCamera = Camera.main;
        playerStats = GetComponent<PlayerStats>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            TryPlant();
        }
    }

    /**
     * Intenta plantar una planta en la posición actual.
     */
    private void TryPlant()
    {
        Ray ray = mainCamera.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2));
        RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo, playerStats.interactionDistance, plantingMask))
        {
            if (hitInfo.collider.CompareTag("Ground"))
            {
                Vector3 plantPosition = hitInfo.point;

                if (IsPlacementValid(plantPosition))
                {
                    PlantObject(plantPosition);
                }
                else
                {
                    Debug.Log("No se puede plantar aquí, ¡área obstruida!");
                }
            }
        }
    }

    /**
     * Verifica si la posición dada es válida para plantar.
     */
    private bool IsPlacementValid(Vector3 position)
    {
        PlantGrowth plantGrowthInfo = plantPrefab.GetComponent<PlantGrowth>();
        if (plantGrowthInfo == null)
        {
            Debug.LogError("¡El 'plantPrefab' no tiene el script PlantGrowth! No se puede validar la posición.");
            return false;
        }

        float matureDiameter = Mathf.Max(plantGrowthInfo.matureSize.x, plantGrowthInfo.matureSize.z);
        float matureRadius = matureDiameter / 2;

        Collider[] colliders = Physics.OverlapSphere(position, matureRadius, obstacleMask);

        return colliders.Length == 0;
    }

    /**
     * Planta un objeto en la posición dada.
     */
    private void PlantObject(Vector3 position)
    {
        if (plantPrefab != null)
        {
            Instantiate(plantPrefab, position, Quaternion.identity);
        }
    }
}
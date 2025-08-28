using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    // Ya no necesitamos una variable de distancia aquí, la quitamos.
    public LayerMask interactionMask;

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
        Debug.DrawRay(mainCamera.transform.position, mainCamera.transform.forward * playerStats.interactionDistance, Color.red);

        if (Input.GetKeyDown(KeyCode.E))
        {
            TryInteract();
        }
    }

    private void TryInteract()
    {
        Ray ray = mainCamera.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2));
        RaycastHit hitInfo;

        // --- LÍNEA MODIFICADA ---
        // También usamos la distancia de interacción desde nuestro script central PlayerStats.
        if (Physics.Raycast(ray, out hitInfo, playerStats.interactionDistance, interactionMask))
        {
            if (hitInfo.collider.CompareTag("Plant"))
            {
                PlantGrowth plant = hitInfo.collider.GetComponent<PlantGrowth>();
                if (plant != null && plant.isMature)
                {
                    plant.Harvest();
                }
            }
        }
    }
}
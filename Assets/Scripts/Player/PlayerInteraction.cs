using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public LayerMask interactionMask;

    private Camera mainCamera;
    private PlayerStats playerStats;

    void Start()
    {
        mainCamera = Camera.main;
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

    /**
    * Método para intentar interactuar con un objeto.
    */
    private void TryInteract()
    {
        Ray ray = mainCamera.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2));
        RaycastHit hitInfo;

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
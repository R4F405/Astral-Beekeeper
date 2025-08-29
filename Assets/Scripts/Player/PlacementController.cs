using UnityEngine;

public class PlacementController : MonoBehaviour
{
    [Header("Configuración de Construcción")]
    public GameObject objectToPlacePrefab;
    public LayerMask placementMask;

    [Header("Materiales de Vista Previa")]
    public Material validPlacementMaterial;
    public Material invalidPlacementMaterial;

    private GameObject currentPlacingObject;
    private bool isPlacing = false;
    private bool isValidPlacement = false;
    private Camera mainCamera;
    private PlayerStats playerStats;
    private int ignoreRaycastLayer;

    void Start()
    {
        mainCamera = Camera.main;
        playerStats = GetComponent<PlayerStats>();
        ignoreRaycastLayer = LayerMask.NameToLayer("Ignore Raycast");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            if (isPlacing)
            {
                CancelPlacement();
            }
            else
            {
                StartPlacement();
            }
        }

        if (isPlacing)
        {
            UpdatePlacementPreview();
            if (Input.GetButtonDown("Fire1") && isValidPlacement)
            {
                PlaceObject();
            }
        }
    }

    /**
    * Método para iniciar la colocación del objeto.
    */
    void StartPlacement()
    {
    isPlacing = true;
    currentPlacingObject = Instantiate(objectToPlacePrefab);

    // --- LÍNEAS A AÑADIR ---
    // Obtenemos el collider del objeto de vista previa y lo convertimos en Trigger.
    // Esto evita que choque y empuje al jugador o a otros objetos.
    Collider previewCollider = currentPlacingObject.GetComponent<Collider>();
    if (previewCollider != null)
    {
        previewCollider.isTrigger = true;
    }
    // --- FIN DE LÍNEAS A AÑADIR ---

    SetLayerRecursively(currentPlacingObject, ignoreRaycastLayer);
    }

    /**
    * Método para cancelar la colocación del objeto.
    */
    void CancelPlacement()
    {
        isPlacing = false;
        Destroy(currentPlacingObject);
    }

    /**
    * Método para actualizar la vista previa de colocación.
    */
    void UpdatePlacementPreview()
    {
        Ray ray = mainCamera.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2));
        RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo, playerStats.interactionDistance, placementMask))
        {
            currentPlacingObject.transform.position = hitInfo.point;

            if (IsValidPlacementPosition())
            {
                SetPlacementMaterial(validPlacementMaterial);
                isValidPlacement = true;
            }
            else
            {
                SetPlacementMaterial(invalidPlacementMaterial);
                isValidPlacement = false;
            }
        }
        else
        {
            currentPlacingObject.transform.position = new Vector3(0, -1000, 0);
            SetPlacementMaterial(invalidPlacementMaterial);
            isValidPlacement = false;
        }
    }

    /**
    * Método para colocar el objeto.
    */
    void PlaceObject()
    {
        Instantiate(objectToPlacePrefab, currentPlacingObject.transform.position, Quaternion.identity);
        CancelPlacement();
    }

    /**
    * Método para comprobar si la posición de colocación es válida.
    */
    bool IsValidPlacementPosition()
    {
        Collider objectCollider = currentPlacingObject.GetComponent<Collider>();
        if (objectCollider == null) return false;

        Vector3 boxSize = objectCollider.bounds.size * 0.9f;

        Collider[] colliders = Physics.OverlapBox(currentPlacingObject.transform.position, boxSize / 2, Quaternion.identity, placementMask, QueryTriggerInteraction.Collide);

        if (colliders.Length == 0)
        {
            return false;
        }
        
        foreach (var col in colliders)
        {
            if (!col.gameObject.CompareTag("Ground"))
            {
                return false;
            }
        }
        
        return true;
    }

    /**
    * Método para establecer el material de colocación.
    */
    void SetPlacementMaterial(Material mat)
    {
        if (currentPlacingObject != null && mat != null)
        {
            currentPlacingObject.GetComponent<Renderer>().material = mat;
        }
    }

    /**
    * Método para establecer el layer de forma recursiva.
    */
    void SetLayerRecursively(GameObject obj, int newLayer)
    {
        if (obj == null) return;
        obj.layer = newLayer;
        foreach (Transform child in obj.transform)
        {
            if (child == null) continue;
            SetLayerRecursively(child.gameObject, newLayer);
        }
    }
}


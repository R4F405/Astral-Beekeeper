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

    void StartPlacement()
    {
        isPlacing = true;
        currentPlacingObject = Instantiate(objectToPlacePrefab);
        SetLayerRecursively(currentPlacingObject, ignoreRaycastLayer);
    }

    void CancelPlacement()
    {
        isPlacing = false;
        Destroy(currentPlacingObject);
    }

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

    void PlaceObject()
    {
        Instantiate(objectToPlacePrefab, currentPlacingObject.transform.position, Quaternion.identity);
        CancelPlacement();
    }
    
    bool IsValidPlacementPosition()
    {
        Collider objectCollider = currentPlacingObject.GetComponent<Collider>();
        if (objectCollider == null) return false;

        Vector3 boxSize = objectCollider.bounds.size * 0.9f;

        // --- LÍNEA CORREGIDA ---
        // Cambiamos "Ignore" por "Collide" para que la caja detecte también los Triggers.
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

    void SetPlacementMaterial(Material mat)
    {
        if (currentPlacingObject != null && mat != null)
        {
            currentPlacingObject.GetComponent<Renderer>().material = mat;
        }
    }
    
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


using UnityEngine;

public class BeeAI : MonoBehaviour
{
    // Estados posibles para la abeja
    private enum BeeState { SEARCHING_FOR_FLOWER, GOING_TO_FLOWER, GOING_TO_HIVE }
    private BeeState currentState;

    [Header("Configuración de la Abeja")]
    public float moveSpeed = 3f;
    public float searchRadius = 20f;
    public LayerMask flowerLayer; // Configura en el Inspector la capa de las plantas

    // Referencias internas
    private Hive myHive;
    private PlantGrowth targetFlower;
    private Vector3 targetPosition;

    /**
    * Método que se llama al inicio para configurar la abeja.
    */
    void Start()
    {
        // La abeja busca su colmena en el objeto padre.
        myHive = GetComponentInParent<Hive>();
        if (myHive == null)
        {
            Debug.LogError("¡Una abeja no ha podido encontrar su colmena (Hive)!");
            this.enabled = false; // Desactivar si no tiene colmena
        }
        SetState(BeeState.SEARCHING_FOR_FLOWER);
    }

    /**
    * Bucle principal que se ejecuta en cada fotograma.
    */
    void Update()
    {
        switch (currentState)
        {
            case BeeState.SEARCHING_FOR_FLOWER:
                SearchForFlower();
                break;
            case BeeState.GOING_TO_FLOWER:
                MoveTowardsTarget();
                if (Vector3.Distance(transform.position, targetPosition) < 0.2f)
                {
                    SetState(BeeState.GOING_TO_HIVE); // Ha llegado a la flor
                }
                break;
            case BeeState.GOING_TO_HIVE:
                MoveTowardsTarget();
                if (Vector3.Distance(transform.position, targetPosition) < 0.2f)
                {
                    myHive.AddHoney(1); // Entrega la miel
                    targetFlower = null;
                    SetState(BeeState.SEARCHING_FOR_FLOWER); // Vuelve a buscar
                }
                break;
        }
    }

    /**
    * Cambia el estado de la abeja y actualiza su objetivo.
    */
    private void SetState(BeeState newState)
    {
        currentState = newState;
        if (currentState == BeeState.GOING_TO_FLOWER)
        {
            targetPosition = targetFlower.transform.position;
        }
        else if (currentState == BeeState.GOING_TO_HIVE)
        {
            targetPosition = myHive.transform.position;
        }
    }
    
    /**
    * Busca la flor madura más cercana en el radio de búsqueda.
    */
    private void SearchForFlower()
    {
        Collider[] foundColliders = Physics.OverlapSphere(transform.position, searchRadius, flowerLayer);
        float closestDistance = float.MaxValue;
        PlantGrowth closestFlower = null;

        foreach (var col in foundColliders)
        {
            PlantGrowth plant = col.GetComponent<PlantGrowth>();
            if (plant != null && plant.isMature)
            {
                float distance = Vector3.Distance(transform.position, plant.transform.position);
                if (distance < closestDistance)
                {
                    closestDistance = distance;
                    closestFlower = plant;
                }
            }
        }

        if (closestFlower != null)
        {
            targetFlower = closestFlower;
            SetState(BeeState.GOING_TO_FLOWER);
        }
    }

    /**
    * Mueve la abeja hacia su objetivo actual.
    */
    private void MoveTowardsTarget()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
        transform.LookAt(targetPosition); // Opcional: que la abeja mire a su objetivo
    }
}
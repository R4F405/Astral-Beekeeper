using UnityEngine;

public class Hive : MonoBehaviour
{
    [Header("Configuración de la Colmena")]
    public int honeyCapacity = 5; // Viajes de abeja necesarios para llenarse
    public GameObject honeyReadyVisual;

    [Header("Estado")]
    private int currentHoney = 0;
    public bool isReadyToHarvest { get; private set; }

    /**
    * Método que se llama al inicio para inicializar la colmena.
    */
    void Start()
    {
        isReadyToHarvest = false;
        if (honeyReadyVisual != null)
        {
            honeyReadyVisual.SetActive(false);
        }
    }

    /**
    * Añade miel a la colmena. Será llamado por una abeja al regresar.
    */
    public void AddHoney(int amount)
    {
        // Si ya está llena, no hace nada.
        if (isReadyToHarvest) return;

        currentHoney += amount;
        
        // Comprueba si se ha llenado.
        if (currentHoney >= honeyCapacity)
        {
            currentHoney = honeyCapacity;
            isReadyToHarvest = true;
            if (honeyReadyVisual != null)
            {
                honeyReadyVisual.SetActive(true); // Muestra el efecto visual
            }
            Debug.Log("¡Colmena lista para cosechar!");
        }
    }

    /**
    * Permite al jugador cosechar la miel de la colmena.
    */
    public void Harvest()
    {
        if (!isReadyToHarvest) return;

        Debug.Log("Cosechando " + currentHoney + " de miel de la colmena.");
        InventoryManager.instance.AddHoney(currentHoney);

        // Reinicia el estado de la colmena.
        currentHoney = 0;
        isReadyToHarvest = false;
        if (honeyReadyVisual != null)
        {
            honeyReadyVisual.SetActive(false);
        }
    }
}
using UnityEngine;
using TMPro; // Asegúrate de añadir esta línea para poder usar TextMeshPro

// Este script gestiona el inventario del jugador y actualiza la UI.
// Utiliza el patrón Singleton para ser fácilmente accesible desde cualquier otro script.
public class InventoryManager : MonoBehaviour
{
    // --- Singleton Pattern ---
    // Una variable estática para mantener la única instancia de este script.
    public static InventoryManager instance;

    void Awake()
    {
        // Si ya existe una instancia y no soy yo, me destruyo.
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            // Si no existe, me convierto en la instancia.
            instance = this;
        }
    }
    // --- Fin del Singleton ---

    [Header("UI")]
    // Arrastra aquí tu objeto de texto "HoneyCounterText" desde la Jerarquía.
    public TextMeshProUGUI honeyCounterText;

    [Header("Recursos")]
    // La cantidad actual de miel que tiene el jugador.
    private int honeyCount = 0;

    void Start()
    {
        // Al empezar el juego, actualizamos la UI para que muestre el valor inicial (0).
        UpdateHoneyUI();
    }

    // Una función pública que otros scripts pueden llamar para añadir miel.
    public void AddHoney(int amount)
    {
        honeyCount += amount;
        Debug.Log(amount + " de miel añadida. Total: " + honeyCount);
        UpdateHoneyUI();
    }

    // Función privada para actualizar el texto en la pantalla.
    private void UpdateHoneyUI()
    {
        if (honeyCounterText != null)
        {
            honeyCounterText.text = "Miel: " + honeyCount;
        }
    }
}

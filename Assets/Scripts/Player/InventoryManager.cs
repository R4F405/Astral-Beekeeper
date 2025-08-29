using UnityEngine;
using TMPro;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;

    /**
    * Método Awake para inicializar el Singleton
    */
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
    }

    [Header("UI")]
    public TextMeshProUGUI honeyCounterText;

    [Header("Recursos")]
    private int honeyCount = 0;

    void Start()
    {
        UpdateHoneyUI();
    }

    /**
    * Método para añadir miel al inventario.
    */
    public void AddHoney(int amount)
    {
        honeyCount += amount;
        Debug.Log(amount + " de miel añadida. Total: " + honeyCount);
        UpdateHoneyUI();
    }

    /**
    * Función privada para actualizar el texto en la pantalla.
    */
    private void UpdateHoneyUI()
    {
        if (honeyCounterText != null)
        {
            honeyCounterText.text = "Miel: " + honeyCount;
        }
    }
}

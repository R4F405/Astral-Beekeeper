using UnityEngine;

// Este script centraliza todas las estadísticas y configuraciones importantes del jugador.
// De esta forma, otros scripts pueden consultar esta fuente de verdad en lugar de tener sus propias variables duplicadas.
public class PlayerStats : MonoBehaviour
{
    [Header("Configuración de Interacción")]
    // Esta es ahora la ÚNICA variable que controla la distancia para TODAS las interacciones.
    public float interactionDistance = 15f;

    // En el futuro, podríamos añadir más estadísticas aquí:
    // public float health = 100f;
    // public int honeyCarried = 0;
}

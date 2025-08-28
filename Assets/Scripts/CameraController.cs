using UnityEngine;

// Este script controla la rotación de la cámara alrededor de un punto de pivote (el jugador).
// Debe ser colocado en el objeto "CameraPivot" que es hijo del jugador.
public class CameraController : MonoBehaviour
{
    [Header("Configuración de la Cámara")]
    // La sensibilidad del movimiento del ratón. Se puede ajustar para que la cámara gire más rápido o más lento.
    public float mouseSensitivity = 100f;

    // Referencia al Transform del jugador. Lo necesitamos para rotar el cuerpo del personaje.
    public Transform playerBody;

    // Variable para almacenar la rotación vertical (arriba y abajo).
    private float xRotation = 0f;

    // El método Start se llama una vez al inicio.
    void Start()
    {
        // Bloquea el cursor en el centro de la pantalla y lo hace invisible.
        // Esencial para que el control de la cámara en primera/tercera persona se sienta bien.
        Cursor.lockState = CursorLockMode.Locked;
    }

    // El método Update se llama en cada fotograma.
    void Update()
    {
        // --- Lectura de Input del Ratón ---
        // Obtenemos el movimiento del ratón en el eje X (izquierda/derecha).
        // Multiplicamos por la sensibilidad y por Time.deltaTime para que la velocidad de rotación
        // sea independiente de los fotogramas por segundo (FPS) del juego.
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;

        // Obtenemos el movimiento del ratón en el eje Y (arriba/abajo).
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // --- Rotación Vertical (Pitch) ---
        // Restamos el movimiento del ratón en Y a nuestra rotación en X.
        // Se resta porque mover el ratón hacia arriba corresponde a una rotación negativa en X.
        xRotation -= mouseY;

        // Limitamos la rotación vertical para que el jugador no pueda dar una voltereta con la cámara.
        // Mathf.Clamp() asegura que el valor de xRotation nunca sea menor que -90 o mayor que 90.
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        // Aplicamos la rotación vertical SÓLO al pivote de la cámara (este objeto).
        // Usamos Quaternion.Euler para convertir nuestros ángulos de rotación en un Quaternion que Unity entiende.
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);


        // --- Rotación Horizontal (Yaw) ---
        // Rotamos el cuerpo del jugador (el objeto padre) en el eje Y (horizontalmente).
        // Esto hace que el personaje gire sobre sí mismo cuando movemos el ratón a los lados.
        playerBody.Rotate(Vector3.up * mouseX);
    }
}

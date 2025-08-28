using UnityEngine;

// Este script controla el movimiento del jugador, incluyendo caminar y saltar.
public class PlayerController : MonoBehaviour
{
    [Header("Configuración de Movimiento")]
    // La velocidad a la que se moverá el personaje. Puedes ajustarla desde el Inspector de Unity.
    public float moveSpeed = 5f;
    // La fuerza con la que el personaje saltará. Ajústala para un salto más alto o más bajo.
    public float jumpForce = 7f;

    [Header("Configuración de Físicas")]
    // Referencia al componente Rigidbody del jugador, que maneja las físicas.
    private Rigidbody rb;

    [Header("Estado del Jugador")]
    // Una variable para saber si el jugador está tocando el suelo o no.
    private bool isGrounded;

    // El método Start se llama una sola vez, al principio del juego.
    void Start()
    {
        // Buscamos y asignamos el componente Rigidbody que está en el mismo objeto que este script.
        // Es importante para que podamos aplicar fuerzas y mover al personaje.
        rb = GetComponent<Rigidbody>();
    }

    // El método Update se llama en cada fotograma del juego. Es ideal para leer los inputs del jugador.
    void Update()
    {
        // --- Manejo de Movimiento ---
        // Leemos el input de las teclas A/D o las flechas izquierda/derecha.
        float horizontalInput = Input.GetAxis("Horizontal");
        // Leemos el input de las teclas W/S o las flechas arriba/abajo.
        float verticalInput = Input.GetAxis("Vertical");

        // Creamos un vector de dirección basado en los inputs.
        // Usamos transform.right y transform.forward para que el movimiento sea relativo a la dirección a la que mira el personaje.
        Vector3 moveDirection = transform.right * horizontalInput + transform.forward * verticalInput;

        // Normalizamos el vector para que el movimiento en diagonal no sea más rápido.
        moveDirection.Normalize();

        // Aplicamos la velocidad al Rigidbody. Usamos Velocity para un control más directo y responsivo.
        // Mantenemos la velocidad vertical (Y) del Rigidbody para no interferir con la gravedad o el salto.
        rb.linearVelocity = new Vector3(moveDirection.x * moveSpeed, rb.linearVelocity.y, moveDirection.z * moveSpeed);


        // --- Manejo de Salto ---
        // Comprobamos si el jugador ha pulsado la barra espaciadora Y si está en el suelo.
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            // Si ambas condiciones son ciertas, aplicamos una fuerza vertical para hacer que salte.
            // Usamos ForceMode.Impulse para aplicar una fuerza instantánea, como un empujón.
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    // Este método se usa para detectar colisiones.
    void OnCollisionEnter(Collision collision)
    {
        // Comprobamos si el objeto con el que hemos chocado tiene la etiqueta "Ground".
        // Es una forma sencilla de saber si estamos tocando el suelo.
        // ¡Asegúrate de ponerle la etiqueta "Ground" a tu objeto de suelo en el Inspector!
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    // Este método se usa para detectar cuando dejamos de colisionar con algo.
    void OnCollisionExit(Collision collision)
    {
        // Si dejamos de tocar el suelo, actualizamos la variable.
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}

using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Configuración de Movimiento")]
    public float moveSpeed = 5f;
    public float jumpForce = 7f;

    [Header("Configuración de Físicas")]
    private Rigidbody rb;

    [Header("Estado del Jugador")]
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = transform.right * horizontalInput + transform.forward * verticalInput;

        moveDirection.Normalize();

        rb.linearVelocity = new Vector3(moveDirection.x * moveSpeed, rb.linearVelocity.y, moveDirection.z * moveSpeed);


        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    /**
    * Método llamado al colisionar con otro objeto.
    */
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

    /**
    * Método llamado al dejar de colisionar con otro objeto.
    */
    void OnCollisionExit(Collision collision)
    {
        // Si dejamos de tocar el suelo, actualizamos la variable.
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}

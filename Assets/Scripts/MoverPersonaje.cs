using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPersonaje : MonoBehaviour
{
    // Define la velocidad de movimiento en X y Y
    public float velocidadX = 5.0f;
    public float velocidadY = 5.0f;

    // Define la referencia al RigidBody
    private Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        // Inicializa la referencia al RigidBody
        rb = GetComponent<Rigidbody2D>();
    }

    // Sobrescribe el método FixedUpdate
    void Update()
    {
        // Obtiene el valor de entrada del eje horizontal
        float movHorizontal = Input.GetAxis("Horizontal");
        // Obtiene el valor de entrada del eje vertical
        float movVertical = Input.GetAxis("Vertical");
   
        // Crea un vector de movimiento
        Vector2 movimiento = new Vector2(movHorizontal * velocidadX, rb.velocity.y);

        // Si movVertical es mayor a 0
        if (movVertical > 0)
        {
            movimiento = new Vector2(movimiento.x, movVertical * velocidadY);
        }

        // Aplica el movimiento al RigidBody
        rb.velocity = movimiento;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiaAnimacion : MonoBehaviour
{
    // Declarar una referencia al Animator
    private Animator animator;

    // Declarar una referencia al Rigidbody
    private Rigidbody2D rb;

    // Declarar la referencia al SpriteRenderer
    private SpriteRenderer spriteRenderer;


    // Start is called before the first frame update
    void Start()
    {
        // Inicializa el Animator
        animator = GetComponent<Animator>();
        // Inicializa el Rigidbody
        rb = GetComponent<Rigidbody2D>();
        // Inicializa el SpriteRenderer
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        animator.SetFloat("velocidad", Mathf.Abs(rb.velocity.x));
        spriteRenderer.flipX = rb.velocity.x < 0f;
        animator.SetBool("saltando", EstadoPersonaje.estaSaltando);
    }
}

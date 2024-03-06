using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoPersonaje : MonoBehaviour
{
    // Declarar una variable booleana para saber si el personaje está en el aire
    public static bool estaSaltando = true;

    // Preguntar si el trigger se activa
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Si el trigger se activa, el personaje no está saltando
        estaSaltando = false;
        print("El personaje llegó al PISO");
    }

    // Preguntar si el trigger se desactiva
    private void OnTriggerExit2D(Collider2D collision)
    {
        // Si el trigger se desactiva, el personaje está saltando
        estaSaltando = true;
        print("El personaje está en el AIRE");
    }


}

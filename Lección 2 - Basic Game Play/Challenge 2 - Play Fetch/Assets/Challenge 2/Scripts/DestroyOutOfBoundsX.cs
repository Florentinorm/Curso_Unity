/*
    Florentino Ramirez Balderas
1219100383 | GDGS2101 | 27/09/2022

Descripción: Se incluyen los limites para cuando un perro o un balon llegue se destruyan en el prefats 
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    // se incluyen los valores de las variables dependiendo de nuestro ecenario 
    private float leftLimit = -38;
    private float bottomLimit = -5;

    // Update is called once per frame
    void Update()
    {
        // se destruyen los perros en la linea X 
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        } 
        // se destruyen las balon en el lado Y
        else if (transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
        }

    }
}

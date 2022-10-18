/*
Florentino Ramirez Balderas
GDGS2101-e | 1219100383 | 18/10/2022

Descripción: Hace que se repita la animacion del fondo
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackgroundX : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWidth;

    private void Start()
    {
        startPos = transform.position; // Establish the default starting position 
        repeatWidth = GetComponent<BoxCollider>().size.x / 2; // Se acomoda el x, ya que es al ancho, y hace que el mapa se mueva correctamente
    }

    private void Update()
    {
        // If background moves left by its repeat width, move it back to start position
        if (transform.position.x < startPos.x - repeatWidth)
        {
            transform.position = startPos;
        }
    }

 
}



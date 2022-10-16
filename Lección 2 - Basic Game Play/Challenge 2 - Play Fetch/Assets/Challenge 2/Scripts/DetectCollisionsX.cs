/*
    Florentino Ramirez Balderas
1219100383 | GDGS2101 | 27/09/2022

Descripción: Solo destruye los objetos
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}

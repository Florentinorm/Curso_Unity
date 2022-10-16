/*
Florentino Ramirez Balderas
GDGS2021 | 1219100383 | 17/09/2022

Descripción: Se hace la funcion para que la camara siga al avion
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;

    //La camara sigue al avion con las cordenadas 30, 0, 10
    private Vector3 offset = new Vector3(30,0,10);

    // Se llama al inicio para poder actualizar el cuadro
    void Start()
    {

    }

    // Pone la camara en la posicion donde se encuentra el jugador
    void Update()
    {
        transform.position = plane.transform.position + offset ;
    }
}

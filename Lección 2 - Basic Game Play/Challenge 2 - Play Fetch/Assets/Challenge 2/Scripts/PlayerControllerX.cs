/*
    Florentino Ramirez Balderas
1219100383 | GDGS2101 | 27/09/2022

Descripción: A cierto tiempo se crea un perro nuevo
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float tiemEsp =1;
    private float tiemDisparo = 0;

    void Update()
    {
      
        //Tiempo para el disparo
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > tiemDisparo)
        {   
            //aparece un perro cada cierto tiempo 
            tiemDisparo = Time.time + tiemEsp;
            //crea copias del perro donde se encuentra el jugador
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

        }
    }
}

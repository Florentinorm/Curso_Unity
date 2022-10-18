/*
Florentino Ramirez Balderas 
1819100383 | GDGS2101 | 05/10/2022

Descripción: Aqui se movera el ecenario
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackgorund : MonoBehaviour
{
    private PlayerController pc; //Se crea la variable pc

    // Start is called before the first frame update
    void Start()
    {
        pc = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -50){ //Si la posicion del fondo es menor a la pocicion en la que se repite esta tomara la pococion inicial
            transform.position = new Vector3(45, 9.5F, 4F);
        }

        if(pc.gameOver == false){
            transform.Translate(Vector3.left*Time.deltaTime*20);
        }
    }
}

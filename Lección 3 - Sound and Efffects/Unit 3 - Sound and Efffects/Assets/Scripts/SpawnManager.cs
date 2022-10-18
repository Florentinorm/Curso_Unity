/*
Florentino Ramirez Balderas 
1819100383 | GDGS2101 | 05/10/2022

Descripción: Aqui se generan las cercas
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaculo;
    private PlayerController pc;

    // Start is called before the first frame update
    void Start()
    {
        pc = GameObject.Find("Player").GetComponent<PlayerController>(); //Se toma el jugador
        InvokeRepeating("Spaw", 1.5F, 1.5F); //Se hace la repeticion en el spawn con un tiempo de espera y salida
    }

    private void Spaw(){
        if(pc.gameOver == false){ //Si se choca con el obstaculo dejaran de aparecer
            Instantiate(obstaculo, new Vector3(35,0,0), obstaculo.transform.rotation);
        }
    }

}

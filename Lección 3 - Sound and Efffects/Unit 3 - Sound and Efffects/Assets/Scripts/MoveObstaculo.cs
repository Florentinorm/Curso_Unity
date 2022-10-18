/*
Florentino Ramirez Balderas 
1819100383 | GDGS2101 | 05/10/2022

Descripción: Se mueven los obstaculos
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstaculo : MonoBehaviour
{
    private PlayerController pc;

    // Start is called before the first frame update
    void Start()
    {
        pc = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {   
        if(pc.gameOver == false){
            transform.Translate(Vector3.left*Time.deltaTime*20);
        }
    }
}

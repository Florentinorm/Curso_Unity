/* 
Florentino Ramírez Balderas
GDGS2021 | 1219100383 | 23/09/2022

Descripción: Crea varios huesos y hace que el jugador se pueda mover
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject proyectilBone;
    float horInput;
    float limiteMov = 20; //limite para que el player no caiga fuera del plano

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Limita el campo de movimineto del Player
        if(transform.position.x > limiteMov){ //Limite para no caer a la derecha
            transform.position = new Vector3(limiteMov, transform.position.y, transform.position.z);
        }
        if(transform.position.x < -limiteMov){  //Limite para no caer a la izquierda
            transform.position = new Vector3(-limiteMov, transform.position.y, transform.position.z);
        }

        if(Input.GetKeyDown(KeyCode.Space)){ //Crea un hueso en la posision del Player cada se oprime la tecla de espacio 
            Instantiate(proyectilBone, transform.position, proyectilBone.transform.rotation);
        }

        // Movimientos del Player
        horInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*Time.deltaTime*20*horInput);
    }
}

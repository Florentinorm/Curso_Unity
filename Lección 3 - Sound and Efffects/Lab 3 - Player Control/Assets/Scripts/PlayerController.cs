/*
Florentino Ramirez Balderas 
GDGS2101 | 1219100383 | 18/10/2022

Descripción: Se agegan los movimientos y restricciones del player
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10.0f; //Se declara la variable de velocidad
    private Rigidbody playerRb; //Se declara la variable playerRb
    private float zBound = 6;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Se crean los metodos
        MovePlayer();
        ConstrainPlayerPosition();
    }

    //Mueve al jugador según la entrada de la tecla de flecha
    void MovePlayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); //Se agrega el movimiento de manera horizontal
        float verticalInput = Input.GetAxis("Vertical"); //Se agrega el movimiento de manera vertical

        playerRb.AddForce(Vector3.forward * speed * verticalInput); //Se mueve en el vector de manera verticar
        playerRb.AddForce(Vector3.right * speed * horizontalInput); //Se mueve en el vector de manera horizontal
    }

    //Impide que el jugador abandone la parte superior o inferior de la pantalla
    void ConstrainPlayerPosition()
    {
        //Limita un area para que no se pueda caer el player
        if(transform.position.z < -zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zBound);
        }

        if(transform.position.z > zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBound);
        }
    }
}

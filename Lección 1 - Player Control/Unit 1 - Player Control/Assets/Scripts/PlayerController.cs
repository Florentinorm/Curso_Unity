/*
Florentino Ramirez Balderas
1919100383 | GDGS2101 | 14/09/2022

Descripción: Mueve el objeto hacia adelante y para atras, tambien puede girar a la derecha o izquiera
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidad = 20; //variable para establecer la velocidad
    public float velGiro = 20; //Variable para establecer la velocidad del giro
    private float avanza; //variable para avnsar
    private float gira;//variable para girar
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //se esta ejecutano constantemente 
    void Update()
    {
        avanza = Input.GetAxis("Vertical"); //para avanzar adelante y para atras
        gira = Input.GetAxis("Horizontal"); //para girar

        transform.Translate(Vector3.forward*Time.deltaTime*velocidad*avanza); //Solo se mueve la Z
        transform.Rotate(Vector3.up*Time.deltaTime*velGiro*gira);
    }
}

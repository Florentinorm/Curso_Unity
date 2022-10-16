/*
Florentino Ramirez Balderas
1919100383 | GDGS2101 | 14/09/2022

Descripción: La camara sigue al objeto
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    
    public GameObject tanque; //el GameObject resulta ser un objeto
    public Vector3 upCam = new Vector3(0,10,-10);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = tanque.transform.position + upCam; //posicion del tanque
    }
}

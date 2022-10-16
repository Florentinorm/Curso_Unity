/* 
Florentino Ramírez Balderas
GDGS2021 | 1219100383 | 23/09/2022

Descripción: mueve el hueso y destruye los objetos que colicionan con el 
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveBone : MonoBehaviour
{
    public float distance = 21;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Mover el hueso
        if(transform.position.z > distance){ //destruye el hueso
            Destroy(gameObject);    
        }
        transform.Translate(Vector3.forward*Time.deltaTime*20);//mueve el hueso
    }
}

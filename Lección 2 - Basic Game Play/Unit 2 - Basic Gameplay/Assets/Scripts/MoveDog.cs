/* 
Florentino Ramírez Balderas
GDGS2021 | 1219100383 | 23/09/2022

Descripción: Mueve el perro hacia adelante 
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class MoveDog : MonoBehaviour
{
    float limite = 23;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z < -limite){
            Destroy(gameObject);    // Se destruye el perro
        }
        transform.Translate(Vector3.forward*Time.deltaTime*15);//hace que el perro se mueva
    }
}

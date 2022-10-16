/* 
Florentino Ramírez Balderas
GDGS2021 | 1219100383 | 23/09/2022

Descripción: Destruye a los objetos que colicionan
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colisionador : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {    
        Destroy(gameObject); //Va destruyendo los objetos 
    }
}

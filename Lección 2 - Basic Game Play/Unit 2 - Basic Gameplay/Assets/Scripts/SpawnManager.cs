/* 
Florentino Ramírez Balderas
GDGS2021 | 1219100383 | 23/09/2022

Descripción: Se crean los animales aleatoriamente
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnManager : MonoBehaviour
{
    public GameObject[] arrDogs; //se crean los animales en el prefast

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateAnimal", 1.5F, 1.5F);//invoca una funcion para un determinado tiempo
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Crea los animales aleatoriamente 
    void CreateAnimal(){ 

        int aleatorio = Random.Range(0,3);
        int valX = Random.Range(-20,20);

        Instantiate(arrDogs[aleatorio], //instancia para que los animales se puedan crear aleatoriamnete
                new Vector3(valX, 
                0, 11), 
                arrDogs[aleatorio].transform.rotation);

    }
}

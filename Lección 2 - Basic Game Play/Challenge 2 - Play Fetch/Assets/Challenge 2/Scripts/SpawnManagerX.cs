/*
    Florentino Ramirez Balderas
1219100383 | GDGS2101 | 27/09/2022

Descripción: Se crean balones aleatoriamente 
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnRandomBall", startDelay);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
         //se crea un indice de manera aleatoria
        int balon = Random.Range(0,3);
        
        // genera un balon en un lugar ramdom
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
    
        // instancia el balon un un lugar de generacion aleatoria
        Instantiate(ballPrefabs[balon], spawnPos, ballPrefabs[balon].transform.rotation);
       
        startDelay = Random.Range(1,5);
        Invoke("SpawnRandomBall", startDelay);

    }

}

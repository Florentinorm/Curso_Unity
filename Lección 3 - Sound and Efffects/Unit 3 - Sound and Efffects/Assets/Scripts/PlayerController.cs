/*
Florentino Ramirez Balderas 
1819100383 | GDGS2101 | 05/10/2022

Descripción: Aqui se generan los movimientos, animaciones, sonidos, efectos del jugador
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{

    private Rigidbody rb; //Se declara un objeto Rigidbody 

    public bool isGround = true; //Valor booleano que verifica si se encuentra en en el suelo

    public bool gameOver = false; //Se declara el mensaje de Game Over

    public int lifes = 4; //Vidas con las que cuenta el jugador

    public GameObject cubeLifes; //Se crea el objeto del cubo correspondiente a la vida del jugador

    private Animator animatorPlayer; //Constante perteneciente a la animacion del jugador

    public ParticleSystem explosion; //Constante de las particulas para la explosion 

    public ParticleSystem humo; //Constante para las chispas

    public AudioClip jump; //Clip del audio para saltar

    public AudioClip crash; //clip del audio para chocar

    private AudioSource audioSource; //Sonido de fondo

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); //Se obtiene el Rigidbody
        animatorPlayer = GetComponent<Animator>(); //amination del personaje
        audioSource = GetComponent<AudioSource>(); //para extraer el audio que se asigno
        humo.Play(); //se inicia las chispas
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)&& isGround == true){ //Si se preciona espacio y se esta en el suelo el jugador saltara
            rb.AddForce(Vector3.up * 800, ForceMode.Impulse);//cada vez que salte **-
            isGround = false; //Se cambia el valor cuando se esta en el aire
            humo.Stop();//para que se detenga el humo
            audioSource.PlayOneShot(jump,1.0F); //cuando salte durara 1 segundo 
            //cuando salte el animator playerr interactua con las variables //**que haga la animacion de saltando y corriendo
            animatorPlayer.SetTrigger("Jump_trig"); //se realisa la animacion al saltar
        }
    }



    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Obstaculo")){
            lifes--;
            //cubeLifes.GetComponent<MeshRenderer>().scale
            if(lifes <= 1){ 
                gameOver = true;//cuando se muera hace esta animacion 
                explosion.Play(); //Cuando choca se realisa la animacion de explocion
                cubeLifes.SetActive(false);//desaparecer el cubo
                audioSource.PlayOneShot(crash,1.0f); //Se reproduce un sonido al chocar
                humo.Stop(); //para que ya no salga humo cuando choque
                animatorPlayer.SetBool("Death_b", true); //Se realisa una animacion de tipo muerte cuando el jugador choca
                animatorPlayer.SetInteger("DeathType_int",2); 
                Debug.Log("Game over!"); //Se muestra en consola Game over! cuando el juego se termino
            }
            cubeLifes.transform.localScale = new Vector3(lifes,1,1); //Va perdiendo escala la barra de vida cuando valla chocando
            
        }else if (other.gameObject.CompareTag("Ground")){
            isGround = true;
             humo.Play(); 

        } 
    }
}

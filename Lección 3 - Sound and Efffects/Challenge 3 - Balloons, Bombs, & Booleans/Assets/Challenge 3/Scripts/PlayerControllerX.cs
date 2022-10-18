/*
Florentino Ramirez Balderas
GDGS2101-e | 1219100383 | 18/10/2022

Descripción: Se generan los movimientos, sonidos y efectos del jugador
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public bool gameOver;

    public float floatForce;
    private float gravityModifier = 1.5f;
    private Rigidbody playerRb;

    public ParticleSystem explosionParticle; //Animacion de explocion
    public ParticleSystem fireworksParticle; //Animacion de particulas

    private AudioSource playerAudio; //Sonido de fondo
    public AudioClip moneySound; //Sonido cuando se toma una moneda
    public AudioClip explodeSound; //Sonido cuando se toca una bomba
    public AudioClip boing; //Sonido de rebote

    public bool tooHigh;//Se crea un valor publico para subier o bajar el globo


    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity *= gravityModifier;
        playerAudio = GetComponent<AudioSource>();

        playerRb = GetComponent<Rigidbody>(); // el jugador rb es igual al componente del cuerpo rigido

        // Apply a small upward force at the start of the game
        playerRb.AddForce(Vector3.up * 5, ForceMode.Impulse);

    }

    // Update is called once per frame
    void Update()
    { 
        //sirve para hacer subir o bajar el globo
        if(transform.position.y > 15) tooHigh = false;
        else tooHigh = true;
        // While space is pressed and player is low enough, float up
        if (Input.GetKey(KeyCode.Space) && tooHigh && !gameOver)
        {
            playerRb.AddForce(Vector3.up * floatForce);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        // if player collides with bomb, explode and set gameOver to true
        if (other.gameObject.CompareTag("Bomb"))
        {
            explosionParticle.Play();
            playerAudio.PlayOneShot(explodeSound, 1.0f);
            gameOver = true;
            Debug.Log("Game Over!");
            Destroy(other.gameObject);
        } 

        // if player collides with money, fireworks
        else if (other.gameObject.CompareTag("Money"))
        {
            fireworksParticle.Play(); //se llaman los fuegos artificiales
            playerAudio.PlayOneShot(moneySound, 1.0f);
            Destroy(other.gameObject);

        //Evita que golpie el suelo y que se genere un fuerza hacia arriba
        }else if(other.gameObject.CompareTag("Ground") && !gameOver) {
            playerRb.AddForce(Vector3.up * 10, ForceMode.Impulse);
            playerAudio.PlayOneShot(boing, 2.0f); //se produce el sonido 
        }

    }

}

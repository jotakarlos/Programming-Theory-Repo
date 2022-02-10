using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    // Encapsulamiento
    public int healt { get; protected set; }
    public int damage { get; protected set; }
    public int puntos { get; protected set; }
    
   
    private Arma1Controller arma;
    public PlayerController playerController;
  
    // Start is called before the first frame update
    void Start()
    {
      
       
    }

    // Update is called once per frame
    void Update()
    {
       


    }
    

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            
           HacerDamage();
            Debug.Log("Daño al jugador: " + damage);
             Debug.Log("Vida del jugador: " + playerController.vidaJugador);
            
           
        }

    }

    
    protected abstract void HacerDamage();

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Arma"))
        {
            arma = other.gameObject.GetComponent<Arma1Controller>();
            healt -= arma.damageArma;
            Debug.Log("Daño al Enemigo: " + arma.damageArma);
            Debug.Log("Vida del enemigo: " + gameObject.name + " : " +healt);
            if (healt<=0)
            {
                Destroy(gameObject);
               playerController.UpdatePuntos(puntos);
            
            }
            
            
        }
    }
}

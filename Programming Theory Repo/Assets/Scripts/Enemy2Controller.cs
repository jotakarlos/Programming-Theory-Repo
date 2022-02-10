using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Controller : Enemy // Herencia
{
    private int healt2 = 5;
    private int damage2 = 2;
    private int puntos2 = 2;

   
    // Start is called before the first frame update
    void Start()
    {
        healt = healt2;
        puntos = puntos2;
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Polimorfismo
    protected override void HacerDamage()
    {
        playerController.UpdateVidaJugador(damage2);
    }
}

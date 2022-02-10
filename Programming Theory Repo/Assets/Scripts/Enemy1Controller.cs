using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Controller : Enemy  // Herencia
{

    private int healt1 = 3;
    private int damage1 = 1;
    private int puntos1 = 1;
    
   
    // Start is called before the first frame update
    void Start()
    {
        healt = healt1;
        puntos = puntos1;
    }

    // Polimorfismo
    protected override void HacerDamage()
    {
        playerController.UpdateVidaJugador(damage1);
    }
}

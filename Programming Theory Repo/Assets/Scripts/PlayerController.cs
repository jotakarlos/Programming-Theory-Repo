using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Encapsulamiento
    [SerializeField]public int vidaJugador { get; private set; }
    public float speed;

    private int puntos;
    private float inputHorizontal;
    private float inputVertical;

    
    // Start is called before the first frame update
    void Start()
    {
        vidaJugador = 10;
        puntos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // Abstracción
        Mover();
    }

    private void Mover()
    {
        inputHorizontal = Input.GetAxis("Horizontal");
        inputVertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * inputVertical * speed * Time.deltaTime);
        transform.Translate(Vector3.right * inputHorizontal * speed * Time.deltaTime);
    }

    public void UpdateVidaJugador(int vida)
    {
        vidaJugador -= vida;
    }

    public void UpdatePuntos(int puntosEnemigo)
    {
        puntos += puntosEnemigo;
        Debug.Log("Puntos del Jugador: " + puntos);
    }
}

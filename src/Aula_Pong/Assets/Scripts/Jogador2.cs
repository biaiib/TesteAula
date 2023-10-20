using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador2 : MonoBehaviour
{
    void Start() 
    {

    }

    void Update()
    {
        if ((Input.GetAxisRaw("Vertical2") > 0) && (transform.position.y < 6.5f))//xisRaw é um comando de eixo
        {
            transform.Translate(0, 0.1f, 0); //transform controla a posição, a rotação e a escala - (x, y, z)
        }
        else if ((Input.GetAxisRaw("Vertical2") < 0) && (transform.position.y > -6.5f))
        {
            transform.Translate(0, -0.1f, 0);
        }
    }
}

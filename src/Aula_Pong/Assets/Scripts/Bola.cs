using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    public AudioSource audioSource;
   
    void Start()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        
        GetComponent<Rigidbody>().velocity = new Vector2(10 * x, 10 * y); //a velocidade do RigidBody (bola) recebe esse vetor
    
    }

    void Update()
    {
        
    }

    void OnCollisionEnter(Collision batida)
    {
        audioSource.Play();
        if (batida.gameObject.name == "Esquerda")
        {
            transform.position = new Vector2(0, 0);
            Start();
        }
    }
}

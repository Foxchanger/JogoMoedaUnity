using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class moedaChao : MonoBehaviour
{
    public AudioSource Lose;

    void OnCollisionEnter2D(Collision2D c)
    {
        

        if (c.collider.tag == "Item")
        {
            Vector2 novaPosicao = new Vector2(Random.Range(-8.39f, 8.61f), Random.Range(5.3f, 5.3f));
            c.transform.position = novaPosicao;
            moverPersonagens.vida--;
            Lose.Play();   
            
        }
    }

    }


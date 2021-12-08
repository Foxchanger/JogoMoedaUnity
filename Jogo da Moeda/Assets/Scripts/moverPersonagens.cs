using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverPersonagens : MonoBehaviour
{
    private int velocidade;
    public static int moeda,vida;

    public AudioSource Coin;
    
    

    // Use this for initialization
    void Start()
    {
        transform.position = new Vector3(0.12f, -3.08f, 0.0f);
        velocidade = 5;
        moeda = 0;
        vida = 5;
        cairMoeda.velocidadeY = -2.0f;
    }

    // Update is called once per frame
    void Update()
    {

       
             

    }
    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.collider.tag == "Item")
        {
            Vector2 novaPosicao = new Vector2(Random.Range(-8.39f, 8.61f), Random.Range(5.3f, 5.3f));
            c.transform.position = novaPosicao;
            contagemMoeda.moeda++;
            if (velocidade < 20)
            {
                velocidade++;
            }
            Coin.Play();
            


        }

        if (c.collider.tag == "barreiradireita")
        {
            transform.position = new Vector3(-9.48f, -3.41f, -0.52f);

        }

        if (c.collider.tag == "barreiraesquerda")
        {
            transform.position = new Vector3(9.23f, -3.19f, -0.52f);

        }

    }

     void FixedUpdate()
    {
        if(vida >=0)
        {
            float px = Input.GetAxisRaw("Horizontal") * velocidade * Time.deltaTime;
            float py = Input.GetAxisRaw("Vertical") * velocidade * Time.deltaTime;
            transform.Translate(px, 0.0f, 0.0f);
        }

        if (vida <0 )
        {
            cairMoeda.velocidadeY = 10;
        }
    }

}









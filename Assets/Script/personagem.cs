using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class personagem : MonoBehaviour {
     //Variaveis utilizadas
    SpriteRenderer sr;
    float px, py;
    public float velocidade, moeda, vida, ar;



	// Use this for initialization
	void Start () {
        //Peixe comecar em cima no centro
        transform.position = new Vector3(0.02f, 4.0f, 0.0f);
		
	}
	
	// Update is called once per frame
	void Update () {
        //Ativar o flip do peixe para ficar do mesmo lado que apertou a tecla Exemplo apertou a seta pro lado esquerdo peixe vira junto
        if (Input.GetAxisRaw("Horizontal") < 0.0f)
        {
            sr = GetComponent<SpriteRenderer>();
            sr.flipX = false;
        }
        else if (Input.GetAxisRaw("Horizontal") > 0.0f)
        {
            sr = GetComponent<SpriteRenderer>();
            sr.flipX = true;
        }
        
        //Fazer o peixe se mover para lados, cima e baixo
        float px = Input.GetAxisRaw("Horizontal") * velocidade * Time.deltaTime;
        float py = Input.GetAxisRaw("Vertical") * velocidade * Time.deltaTime;
        transform.Translate(px, py, 0.0f);
    }
     void OnCollisionEnter2D(Collision2D c)
        //Quando colidir com peixe aparecer em outro lugar 
    {
        if (c.collider.tag == "moedaesquerda")
        {
            Vector2 novaPosicao = new Vector2(Random.Range(-3.08f, -3.08f), Random.Range(3.73f, -4.74f));
            c.transform.position = novaPosicao;
            //velocidade = velocidade + 1.5f;
            moeda++;
         }

        if(c.collider.tag == "tubarao")
        {
            transform.position = new Vector3(0.02f, 4.0f, 0.0f);
            vida--;
            print(vida);
            
        }
       }
    void OnCollisionStay2D(Collision2D c)
    {
        if(c.collider.tag == "ar")
        {
            ar--;
        }
       // print(c.gameObject.name);
    }
     void OnCollisionStay(Collision c)
    {
        print(c.gameObject.name);
    }
}

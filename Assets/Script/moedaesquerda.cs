using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moedaesquerda : MonoBehaviour {
    public float velocidadeX, velocidadeY;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(velocidadeX * Time.deltaTime, velocidadeY * Time.deltaTime, 0.0f);

    }
    /*void OnCollisionEnter2D(Collision2D c)
    {
        if (c.collider.tag == "Player")
        {
            velocidadeY--;
        }
    }*/
    
}


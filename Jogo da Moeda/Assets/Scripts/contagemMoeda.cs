using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class contagemMoeda : MonoBehaviour {
    public Text txtmoeda;
    public static int moeda;
	public Text txtVida;



	void Update () {
        txtmoeda.text = moeda.ToString();
		txtVida.text = moverPersonagens.vida.ToString();
	}
}

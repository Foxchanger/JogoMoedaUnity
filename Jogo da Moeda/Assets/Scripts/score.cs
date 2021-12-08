using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public GameObject painel;
    public Text scoreText;
    public GameObject imagem,texto;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = contagemMoeda.moeda.ToString();

        if (moverPersonagens.vida <0)
        {
            painel.SetActive(true);
            imagem.SetActive(false);
            texto.SetActive(false); 
        }
        else
        {
            painel.SetActive(false);
            imagem.SetActive(true);
            texto.SetActive(true);

        }
     
        
    }


}

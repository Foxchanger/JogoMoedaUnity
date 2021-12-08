using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMoeda : MonoBehaviour
{
    public GameObject coinPrefab;

    



    void Update()
    {
        if (moverPersonagens.vida >0)
        {
            Instantiate(coinPrefab, transform.position = new Vector3((Random.Range(-8.0f, 8.0f)), 6), transform.rotation);
        }
        
    }

    

}


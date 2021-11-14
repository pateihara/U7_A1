using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject diamante;
    public Transform[] spawnPoint;

    public int contagemGemas = 0;

    public int i;

    GameObject[] gameObjects;

    public void Start()
    {
        for (i = 0; i < 3; i++)
        {
            gameObjects = GameObject.FindGameObjectsWithTag("gema");
            Debug.Log("spot:" + spawnPoint[i]);
            GemasNascer();
        }
    }
    public void Update()
    {

    }

    public void GemasNascer()
    {
        //int index = Random.Range(0, spawnPoint.Length);
        //Transform spawnPoint = spawnPoint[index];


        Instantiate(diamante);
        contagemGemas++;
        Debug.Log("contagem gemas:" + contagemGemas);
    }

}

/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject diamante;
    public Transform[] spawnPoint;

    public int contagemGemas = 0;

    public int i;

    GameObject[] gameObjects;
    

    public void Start()
    {
        Instantiate(diamante, spawnPoint[Random.Range(0, spawnPoint.Length)]);
        Instantiate(diamante, spawnPoint[Random.Range(0, spawnPoint.Length)]);
        Instantiate(diamante, spawnPoint[Random.Range(0, spawnPoint.Length)]);


    }
    public void Update()
    {
        /*
           if (gameObjects.Length <= 2)
            {
                Instantiate(diamante, spawnPoint[Random.Range(0, spawnPoint.Length)]);
                contagemGemas++;
                Debug.Log("contagem gemas:" + contagemGemas);
            }*//*

        gameObjects = GameObject.FindGameObjectsWithTag("gema");
        Debug.Log("quantidade gemas no cenário:" + gameObjects.Length);

        for (i = 0; i < 1; i++)
        {
            if (gameObjects.Length <= 2)
            {
                Instantiate(diamante, spawnPoint[Random.Range(0, spawnPoint.Length)]);
                contagemGemas++;
                Debug.Log("contagem gemas:" + contagemGemas);

            }
        }

        //do{
        //    Instantiate(diamante, spawnPoint[Random.Range(0, spawnPoint.Length)]);
        //}while(gameObjects.Length<3);
        //checkgems();

    }


    public void Esconder()
    {
        this.gameObject.SetActive(false);
    }
}
*/
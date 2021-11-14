using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class central : MonoBehaviour
{
    public GameObject conteudoNascer;
    GameObject[] gameObjects;
    private float tempo = 1f;


    public Transform[] spawnPoint;

    public void Start()
    {
        conteudo();
    }

    public void Update()
    {
        if (GameObject.FindGameObjectsWithTag("gema").Length < 3)
        {

            this.tempo += Time.deltaTime;
            if (this.tempo >= 1f)
            {
                conteudo();
                tempo = 0;
            }
        }
    }
    private void conteudo()
    {

        var aleatorio = spawnPoint[Random.Range(0, spawnPoint.Length)];
        var aleatorio1 = aleatorio;

        aleatorio = spawnPoint[Random.Range(0, spawnPoint.Length)];
        var aleatorio2 = aleatorio;

        aleatorio = spawnPoint[Random.Range(0, spawnPoint.Length)];
        var aleatorio3 = aleatorio;

        while (aleatorio1 == aleatorio2 || aleatorio1 == aleatorio3 || aleatorio2 == aleatorio3)
        {
            aleatorio = spawnPoint[Random.Range(0, spawnPoint.Length)];
            aleatorio1 = aleatorio;

            aleatorio = spawnPoint[Random.Range(0, spawnPoint.Length)];
            aleatorio2 = aleatorio;

            aleatorio = spawnPoint[Random.Range(0, spawnPoint.Length)];
            aleatorio3 = aleatorio;
        }

        for (int i = 0; i < 3; i++)
        {

            Instantiate(conteudoNascer, aleatorio1);

            if (aleatorio1 != aleatorio2 && aleatorio1 != aleatorio3 && aleatorio2 != aleatorio3)
            {
                Instantiate(conteudoNascer, aleatorio2);
                Instantiate(conteudoNascer, aleatorio3);

            }
        }
    }
}





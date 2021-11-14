using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gema : MonoBehaviour
{
    public int pontuacao = 10;

    public void Start()
    {
        var timeToWait = Random.Range(3f, 6f);
        Destroy(this.gameObject, timeToWait);
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            player2D.Pontuacao += pontuacao;
            Destroy(this.gameObject);
        }

    }
}

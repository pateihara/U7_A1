using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canvasPontuacao : MonoBehaviour
{
    public Text textoPontuacao;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        this.textoPontuacao.text = player2D.Pontuacao + "x";
    }
}

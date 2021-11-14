using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mensagemObjetivo : MonoBehaviour
{
    public void Exibir()
    {
        this.gameObject.SetActive(true);
    }

    public void Esconder()
    {
        this.gameObject.SetActive(false);
    }
}

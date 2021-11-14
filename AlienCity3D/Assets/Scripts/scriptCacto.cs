using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class scriptCacto : MonoBehaviour
{
    public int vida = 5;
    void Start()
    {
        //texto = this.transform.GetChild(0).GetChild(0).GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        //texto.text = vida.ToString();

    }


    public void Dano(int _dano){
        vida -= _dano;

        if(vida < 0)
        {
            Destroy(this.gameObject);
        }
    }
}

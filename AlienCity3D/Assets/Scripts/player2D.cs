using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2D : MonoBehaviour
{
    Animator anim;

    // reference to CircleCollider2D component
    Collider2D col;
    private mensagemObjetivo mensagem;
    public static int pontuacao;
    bool estousegurando = false;

    void Start()
    {
        GameObject mensagemObjeto = GameObject.FindGameObjectWithTag("mensagemObjetivo1");
        this.mensagem = mensagemObjeto.GetComponent<mensagemObjetivo>();
        this.mensagem.Esconder();

        anim = GetComponent<Animator>();
        col = GetComponent<Collider2D>();
        pontuacao = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);

            switch (touch.phase)
            {

                case TouchPhase.Began:
                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                    {
                        anim.SetTrigger("flutuando");
                        mensagem.Exibir();
                        estousegurando = true;
                    }
                    break;

                case TouchPhase.Moved:

                    if (estousegurando == true)
                    {
                        Vector3 pos = Camera.main.ScreenToWorldPoint(touch.position);
                        pos.z = 0;
                        transform.position = pos;
                    }
                    break;


                case TouchPhase.Ended:

                    // and if you touch the racket then move in X axis
                    if (col == Physics2D.OverlapPoint(touchPos))
                    {
                        mensagem.Esconder();

                    }
                    break;
            }
        }
    }


    public static int Pontuacao
    {
        get
        {
            return player2D.pontuacao;
        }
        set
        {
            pontuacao = value;
            if (pontuacao < 0)
            {
                pontuacao = 0;
            }
            Debug.Log("Pontuação atualizada para:" + Pontuacao);

        }
    }

}

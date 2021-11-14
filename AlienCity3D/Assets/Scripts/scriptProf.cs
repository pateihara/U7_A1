using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptProf : MonoBehaviour
{
    bool estouTocandoObj = false;
    public LayerMask possoTocar;



    public void Start(){
    }

    void Update(){
        if(Input.touchCount > 0){
            Touch toque = Input.GetTouch(0);

            Vector3 posOriginalConvert = Camera.main.ScreenToWorldPoint(toque.position);
            Vector2 toquePos2D = new Vector2(posOriginalConvert.x, posOriginalConvert.y);

            RaycastHit2D _raycast = Physics2D.Raycast(toquePos2D, Vector2.zero, Mathf.Infinity, possoTocar);
            estouTocandoObj = _raycast;

            if(estouTocandoObj){
                switch(toque.phase){
                    case TouchPhase.Began:
                        _raycast.collider.gameObject.GetComponent<scriptCacto>().Dano(1);
                    break;
                    
                }

            }
        }

    }
}

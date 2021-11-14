using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spotSpawn : MonoBehaviour
{
    void OnCollisionEnter(Collision collisionInfo){
        if(collisionInfo.collider.tag =="gema")
        {
            Debug.Log("tem uma gema igual aqui");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxCollider : MonoBehaviour
{
    
   
    public Transform boxTrans;
    public GameObject anim;
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        Instantiate(anim, boxTrans.position, boxTrans.rotation);
       
    }

}

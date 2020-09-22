
using UnityEngine;

public class EndTriggera : MonoBehaviour
{
    public gameManager sameManager;
    public Rigidbody rb;
    public Vector3 vec;

    void OnTriggerEnter ()
    {
        rb.Sleep();
        sameManager.nextLevel();
       
        
        

    }
   
}

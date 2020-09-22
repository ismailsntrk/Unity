
using UnityEngine;

public class PlayerMovement : MonoBehaviour

{
    public Rigidbody rb;

    public float forwardForge = 2000f;
    public float sideWaysForce = 2000f;
    public float upAndDownForce = 2000f;
    public float upLimit = 250f;
    public Transform player;
    public GameObject closeUI;
    public int say = 0;
    void Start()
    {
       
        
    }

    
    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardForge * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -(forwardForge * Time.deltaTime), ForceMode.VelocityChange);
        }
       
        if (Input.GetKey("d"))
        {
            rb.AddForce(sideWaysForce * Time.deltaTime, 0,0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideWaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if(player.transform.position.y <= upLimit)
        {
            if (Input.GetKey("space"))
            {
                rb.AddForce(0, upAndDownForce * Time.deltaTime, 0, ForceMode.Force);
            }
        }
        if(rb.position.y < -1f)
        {
            FindObjectOfType<gameManager>().endGame();
        }
        if (Input.GetKeyUp("escape"))
        {
            say = say +1 ;
            if (say%2 == 1)
            {
                closeUI.SetActive(true);
               
            }
            else closeUI.SetActive(false);

        }





    }

}

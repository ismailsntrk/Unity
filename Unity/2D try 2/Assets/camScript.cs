
using UnityEngine;

public class camScript : MonoBehaviour
{
    public Transform camTrans;
    public Transform playerTrans;
   

    private void FixedUpdate()
    {

        transform.position = new Vector3(playerTrans.position.x, playerTrans.position.y,transform.position.z);

    }
}

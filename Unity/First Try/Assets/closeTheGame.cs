
using UnityEngine;

public class closeTheGame : MonoBehaviour
{
    public GameObject closeUI;
    public void salm()
    {
        if (Input.GetKey("escape"))
        {
            closeUI.SetActive(true);

        }



    }
}

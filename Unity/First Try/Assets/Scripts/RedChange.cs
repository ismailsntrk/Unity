
using UnityEngine;

public class RedChange : MonoBehaviour
{

    public Material player;


    public void colorChange()
    {
        player.SetColor("_Color", Color.red);
    }


}

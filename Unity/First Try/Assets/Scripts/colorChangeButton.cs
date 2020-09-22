
using UnityEngine;

public class colorChangeButton : MonoBehaviour
{

    public Material player;
    

    public void colorChange()
    {
        player.SetColor("_Color", Color.green);
    }

  
}

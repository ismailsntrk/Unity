
using UnityEngine;

public class Aktarma : MonoBehaviour
{
    public GameObject levelOkey;
    public GameObject colorScreen;

    public void screenChange()
    {
        levelOkey.SetActive(false);
        colorScreen.SetActive(true);
    }
}

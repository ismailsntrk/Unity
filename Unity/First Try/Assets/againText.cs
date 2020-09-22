using UnityEngine.SceneManagement;
using UnityEngine;

public class againText : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadSameLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}


using UnityEngine;
using UnityEngine.SceneManagement;

public class colorNextButton : MonoBehaviour
{
    public GameObject colorUI;
    public GameObject winUI;
    public void LoadNextLevel()
    {
        colorUI.SetActive(false);
        winUI.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

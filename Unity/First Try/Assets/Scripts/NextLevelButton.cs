using UnityEngine.SceneManagement;
using UnityEngine;

public class NextLevelButton : MonoBehaviour
{
   
   
        public void LoadNextLevel()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    


}

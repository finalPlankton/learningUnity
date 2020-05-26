using UnityEngine;

//This is used to change to a different Scene
//or reload the current scene
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public GameObject completeLevelUI;

    public void endGame()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;

            // To end the game instead of calling the function direcly
            // which will reload the game very quickly we will use Invoke()
            // Invoke() will take two arguments - name of the method to call
            // and the delay before which that method is called.
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        // This will load a particular scene.
        // SceneManager.GetActiveScene() will access the current scene
        // and .name will get the name of the scene.
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true); 
    }
}

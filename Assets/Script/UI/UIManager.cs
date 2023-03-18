using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void StartGame(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
    public void Setting()
    {
        //Add Later
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}

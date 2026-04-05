using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUIHandler : MonoBehaviour
{
    public GameObject mainmenu;

    public GameObject gameover;

    public GameObject gamewin;


    public void StartGame()
    {
        print("Start game");
        SceneManager.LoadScene("Final_Scene");
    }

    public void QuitGame()
    {
        print("Quit the game");
        Application.Quit();
    }


}

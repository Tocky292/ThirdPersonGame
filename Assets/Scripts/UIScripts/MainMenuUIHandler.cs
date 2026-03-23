using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUIHandler : MonoBehaviour
{



    public void StartGame()
    {
        print("Start game")
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitGame()
    {
        print("Quit the game")
    }
}

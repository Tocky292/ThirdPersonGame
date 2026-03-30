using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InGameUiHandler : MonoBehaviour
{

    public Image heart1;
    public Image heart2;
    public Image heart3;

  
    public Sprite FullHeartImage;

    public Sprite EmptyHeartImage;

    public TMP_Text textelement;

    private int coinamount = 0;

    public GameObject ingameui;

    public GameObject gameover;

    public GameObject gamewin;


    public void SetHealth(int amount)
    {
        if (amount == 3)
        {
            heart1.sprite = FullHeartImage;
            heart2.sprite = FullHeartImage;
            heart3.sprite = FullHeartImage;
        }
        if (amount == 2)
        {
            heart1.sprite = FullHeartImage;
            heart2.sprite = FullHeartImage;
            heart3.sprite = EmptyHeartImage;
        }
        if (amount == 1)
        {
            heart1.sprite = FullHeartImage;
            heart2.sprite = EmptyHeartImage;
            heart3.sprite = EmptyHeartImage;
        }
        if (amount == 0)
        {
            heart1.sprite = EmptyHeartImage;
            heart2.sprite = EmptyHeartImage;
            heart3.sprite = EmptyHeartImage;
        }
        
    }


    public void IncreaseCoins()
    {
        coinamount++;
        print(coinamount);
        textelement.text = coinamount.ToString() + " x ";



    }




    public void GoToGameover()
    {
        print("gotogameover function ran");
        ingameui.SetActive(false);
        gameover.SetActive(true);
        gamewin.SetActive(false);
    }

    public void GoToGamewin()
    {
        ingameui.SetActive(false);
        gameover.SetActive(false);
        gamewin.SetActive(true);
    }

    public void GoToMainMenu()
    {
        print("main menu btn pressed");
        SceneManager.LoadScene("UI_Scene");
    }

}

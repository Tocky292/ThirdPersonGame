using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InGameUiHandler : MonoBehaviour
{

    public Image heart1;
    public Image heart2;
    public Image heart3;

  
    public Sprite FullHeartImage;

    public Sprite EmptyHeartImage;

    public TMP_Text textelement;

    private int coinamount = 0;


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

}

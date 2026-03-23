using UnityEngine;
using UnityEngine.UI;

public class InGameUiHandler : MonoBehaviour
{

    public Image heart1;
    public Image heart2;
    public Image heart3;

  
    public Sprite FullHeartImage;

    public Sprite EmptyHeartImage;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 1;


    }

    // Update is called once per frame
    void Update()
    {
        RemoveHeart();
        print("frame update");
    }


    public void RemoveHeart()
    {
        if (heart2.sprite == EmptyHeartImage)
        {
            heart1.sprite = EmptyHeartImage;
        }
        
        if (heart3.sprite == EmptyHeartImage)
        {
            heart2.sprite = EmptyHeartImage;
        }

        heart3.sprite = EmptyHeartImage;
       

        
    }

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
}

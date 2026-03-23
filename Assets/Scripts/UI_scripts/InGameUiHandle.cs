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



    }

    // Update is called once per frame
    void Update()
    {

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
}

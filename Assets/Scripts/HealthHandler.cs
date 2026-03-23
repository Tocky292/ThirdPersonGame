using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

[System.Serializable]
public class HealthHandler
{
    public int currentHealth = 3;

    public int maxHealth = 3;

    public GameObject UiHandler;


    public void AddHealth()
    {
        currentHealth ++;
    }


    public void RemoveHealth()
    {
        currentHealth --;

        //InGameUiHandler script = UiHandler.GetComponent<InGameUiHandler>();
        //script.RemoveHeart();
    }


    public void ResetHealth()
    {
        currentHealth = 3; 
    }
}

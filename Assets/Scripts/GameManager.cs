using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    public static GameManager instance;

    public InGameUiHandler UiHandler;

    public int health = 3;

    private bool gameoverscreenactive;

    private bool gamewinscreenactive;



    void Awake()
    {
        // Check if an instance already exists
        if (instance == null)
        {
            instance = this;
            // This prevents the object from being deleted when the scene resets
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // If one already exists, destroy this new one so we don't have duplicates
            Destroy(gameObject);
        }

    }

    // Update is called once per frame
    void Update()
    {
        // updates the health ui so that it shows after youve died
        updateUI();


    }


    public void Removehealth()
    {
        //print("removed a health");
        health --;

        updateUI();

        if (health < 1)
        {
            print("heath is 0 showing gameover");
            //Time.timeScale = 0f;
            InGameUiHandler script = GameObject.Find("InGameUIHandler").GetComponent<InGameUiHandler>();
            script.GoToGameover();
            ResetHealth();
        }
        else
        {
            SceneManager.LoadScene("Final_Scene");
        }

    }


    public void ResetHealth()
    {
        health = 3; 
    }


    public void updateUI()
    {
        InGameUiHandler script = GameObject.Find("InGameUIHandler").GetComponent<InGameUiHandler>();
        script.SetHealth(health);
    }
}

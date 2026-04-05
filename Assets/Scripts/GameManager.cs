using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    public static GameManager instance;

    public InGameUiHandler UiHandler;

    public int health = 3;


    // really just for coin and death sound
    public AudioSource audioSource;
    public AudioClip[] clips;



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


        //play the second clip e.g. death sound
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = clips[1];
        audioSource.Play();


    }

    public void PlayCoinSound()
    {

        //play the first clip e.g. coind sound
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = clips[0];
        audioSource.Play();
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

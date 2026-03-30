using UnityEditor;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public static GameManager instance;

    public int health = 3;





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


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        updateUI();
    }


    public void Removehealth()
    {
        print("removed a health");
        health --;

        updateUI();

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

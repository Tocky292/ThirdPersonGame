using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;


public class ObjectColider : MonoBehaviour
{

    public InGameUiHandler UiHandler;

    public GameManager GameManager;

    public AudioSource audioSource;





    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        

       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  

    public void OnTriggerEnter(Collider other)
    {

        // what to do if you touch a coin
        if(other.CompareTag("Coin"))
        {
            print("Touched Coin"); 

            // destory the coin 
            Destroy(other.gameObject);

            // add one to the ui counter
            InGameUiHandler script = GameObject.Find("InGameUIHandler").GetComponent<InGameUiHandler>();
            script.IncreaseCoins();

            audioSource = GetComponent<AudioSource>();

            audioSource.Play();

        }


        // what to do if you touch a static hazard
        if (other.CompareTag("Hazard"))
        {

            resetScence();
 
        }




    }

    public void resetScence()
    {
        GameManager script = GameObject.Find("GameManagerObject").GetComponent<GameManager>();
        script.Removehealth();
        


        print("resetting scence");
        SceneManager.LoadScene("Final_Scene");

    }




}

using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ObjectColider : MonoBehaviour
{

    public GameObject UiHandler;

    public GameManager GameManager;


    
    
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
            Destroy(other.gameObject);
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
        SceneManager.LoadScene("Ethan_scene");

    }




}

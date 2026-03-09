using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class CharacterMove : MonoBehaviour
{
    [Tooltip("The walking speed")]
    public float speedWalk = 4f;
    [Tooltip("The sprint speed")]
    public float speedSprint = 7f;

    private CharacterController controller;

    private Vector2 inputsThisFrame = new Vector2();

    private Vector3 movement = new Vector3();

    public Transform cameratransform; 
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = GetComponent<CharacterController>();
        //Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

        inputsThisFrame.x = Input.GetAxis("Horizontal");
        //inputsThisFrame.y = Input.GetAxis("Vertical");   removed vertical movement e.g away from the camera
        
        // translate inputs into world space e.g. 3D

        movement = new Vector3(inputsThisFrame.x, 0,0);

        //movement = transform.TransformDirection(movement); // old line for static movement

        movement = cameratransform.TransformDirection(movement);


        // sprint 
        if (Input.GetButton("Sprint"))
        {
            movement *= speedSprint;
        }
        else
        {
            movement *= speedWalk;
        }

        controller.Move(movement * Time.deltaTime);
    }

}

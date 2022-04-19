using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int jumpMultiplier = 5;
    private float horizontalInput;
    private Rigidbody rigidbodyComponent;
    private Canvas uiComponent;
    public float horizontalInputMultiplier = 0.25f; 
    public int jumpCounter; 
    private bool isJumpPressed;
    public int maxJumps = 50;
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        rigidbodyComponent = GetComponent<Rigidbody>();
        uiComponent = GetComponent<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isJumpPressed = true; 
        }

        horizontalInput = Input.GetAxis("Horizontal");
    }

    void FixedUpdate() 
    {
        //kill momentum 
        rigidbodyComponent.velocity = new Vector3(0,rigidbodyComponent.velocity.y, 0);
        rigidbodyComponent.angularVelocity = new Vector3(0, rigidbodyComponent.angularVelocity.y, 0);

        //jump mechanism 
        if (isJumpPressed)
        {
            rigidbodyComponent.AddForce(Vector3.up * jumpMultiplier, ForceMode.Impulse);
            //rigidbodyComponent.AddForce(Vector3.up * jumpMultiplier, ForceMode.VelocityChange);
            jumpCounter ++;
            if (jumpCounter >= maxJumps)
            {
                gameManager.EndGame();
            }

            isJumpPressed = false;

        }


        // move horizontally 
        rigidbodyComponent.MovePosition(transform.localPosition + new Vector3(horizontalInput * horizontalInputMultiplier * Time.fixedDeltaTime, 0, 0));
        // rigidbodyComponent.AddForce(new Vector3(horizontalInput * horizontalInputMultiplier, 0, 0));
        // rigidbodyComponent.velocity = new Vector3(horizontalInput * horizontalInputMultiplier, rigidbodyComponent.velocity.y, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "endLevelTrigger")
        {
            Debug.Log("Number of jumps: " + jumpCounter);
            gameManager.CompleteLevel();
        }
    }
}

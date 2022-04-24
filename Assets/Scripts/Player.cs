using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int JumpForce = 5;
    private float _horizontalInput;
    private Rigidbody _rigidBody;
    private Canvas uiComponent;
    public float Speed = 5f; 
    public int jumpCounter; 
    private bool isJumpPressed;
    public int maxJumps = 50;
    public GameManager gameManager;


    void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
        uiComponent = GetComponent<Canvas>();
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isJumpPressed = true; 
        }

        _horizontalInput = Input.GetAxis("Horizontal");
    }

    void FixedUpdate() 
    {
        //jump mechanism 
        if (isJumpPressed)
        {
            _rigidBody.AddForce(new Vector3(0, JumpForce, 0), ForceMode.Impulse);
            jumpCounter ++;
            if (jumpCounter >= maxJumps)
            {
                gameManager.EndGame();
            }

            isJumpPressed = false;

        }

        // horizontal move mechanism
        transform.position += new Vector3(_horizontalInput, 0, 0) * Time.fixedDeltaTime * Speed;
        if (_horizontalInput == 0)
        {
            _rigidBody.velocity = new Vector3(0, _rigidBody.velocity.y, 0);
        }
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

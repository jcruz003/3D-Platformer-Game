using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 1;
    public float JumpForce = 1;
    private bool jump = false;
    private float _movement;

    public int maxJumps = 30;
    private int _jumpCounter;

    public Text JumpCounterText; 

    private Rigidbody _rigidbody;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        JumpCounterText.text = _jumpCounter.ToString();
    }

    void Update()
    {
        _movement = Input.GetAxis("Horizontal");
    
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;            
        }
    }

    void FixedUpdate() 
    {
        if (jump && (_jumpCounter != maxJumps))
        {
            _rigidbody.AddForce(new Vector3(0, JumpForce, 0), ForceMode.Impulse);
            jump = false;
            _jumpCounter++;
            JumpCounterText.text = _jumpCounter.ToString();
            Debug.Log(JumpCounterText.text);
            
            if (_jumpCounter == maxJumps)
            {
                Debug.Log("No more jumps for you!");
            }
        }
        
        transform.position += new Vector3(_movement, 0, 0) * Time.fixedDeltaTime * Speed;
        if (_movement == 0)
        {
            _rigidbody.velocity = new Vector3(0, _rigidbody.velocity.y, 0);
        }
    }

}

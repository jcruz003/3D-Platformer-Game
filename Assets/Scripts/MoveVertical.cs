using UnityEngine;

public class MoveVertical : MonoBehaviour
{
    public float speed;
    public float maxY;
    public float minY; 
    public bool goingUp = false;

    // Update is called once per frame
    // void FixUpdate()
    // {
    //     var delta = speed * Time.deltaTime;

    //     if (transform.localPosition.y > maxY)
    //     {
    //         goingUp = false;
    //     }
    //     else if (transform.localPosition.y < minY)
    //     {
    //         goingUp = true;
    //     }

    //     if (goingUp == false)
    //     {
    //         delta *= -1;
    //     }

    //     var move = new Vector3(0, delta, 0);
    //     // move by "move" amount defined above
    //     transform.Translate(move);

    //     // this is the equivalent of the transform.Translate line above
    //     // transform.localPosition = transform.localPosition + move;
    // }
    void FixedUpdate()
    {
        var delta = speed * Time.fixedDeltaTime;

        if (transform.localPosition.y > maxY)
        {
            goingUp = false;
        }
        else if (transform.localPosition.y < minY)
        {
            goingUp = true;
        }

        if (goingUp == false)
        {
            delta *= -1;
        }

        var move = new Vector3(0, delta, 0);
        
        // move by "move" amount defined above
        transform.Translate(move);
    }
}

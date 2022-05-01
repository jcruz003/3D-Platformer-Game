using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCube : MonoBehaviour
{
    public Transform position1, position2;
    public float speed;
    public Transform startPosition;
    Vector3 nextPosition;

    // Start is called before the first frame update
    void Start()
    {
        nextPosition = startPosition.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position == position1.position)
        {
            nextPosition = position2.position;
        }
        
        if(transform.position == position2.position)
        {
            nextPosition = position1.position;
        }

        transform.position = Vector3.MoveTowards(transform.position, nextPosition, speed * Time.deltaTime);

    }
    public void OnCollisionEnter(Collision collision)
    {
        collision.transform.SetParent(transform);
    }

    public void OnCollisionExit(Collision collision)
    {
        collision.transform.SetParent(null);
    }
}

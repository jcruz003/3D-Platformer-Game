using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public float speed;
    public float maxY;
    public float minY; 
    public GameObject player; 

    void Start()
    {
        var originalPositionY = transform.localPosition.y;
    }

    void Update()
    {
        var playerPositionY = player.transform.position.y;

        if (playerPositionY > minY & playerPositionY < maxY)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, playerPositionY, transform.localPosition.z);
        }
        
    }
}

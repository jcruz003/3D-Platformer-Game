using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public float speed;

    public Transform min_position;
    public Transform max_position;  
    public Transform player; 

    void Start()
    {
        var startPositionY = transform.localPosition.y;
    }

    void Update()
    {
        var playerPositionY = player.transform.position.y;
        var minY = min_position.transform.localPosition.y;
        var maxY = max_position.transform.localPosition.y;

        if (playerPositionY > minY & playerPositionY < maxY)
        {
            var nextPosition = new Vector3(transform.localPosition.x, playerPositionY, transform.localPosition.z);
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, nextPosition, speed * Time.deltaTime);
        }
        
    }
}

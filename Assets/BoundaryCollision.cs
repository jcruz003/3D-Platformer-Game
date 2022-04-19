using UnityEngine;

public class BoundaryCollision : MonoBehaviour
{
    public GameManager gameManager;
    void OnCollisionEnter (Collision collisionInfo)
    {
        gameManager.EndGame();
        
    }

}

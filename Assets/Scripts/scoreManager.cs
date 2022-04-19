using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{
    public Text scoreText;
    public GameObject playerGO;
    // public Text jumpCounterText;
    // GameObject playerObject = GameObject.Find("Player");

    void Update()
    {
        var player = playerGO.GetComponent<Player>();
        scoreText.text = player.jumpCounter.ToString();
        // Debug.Log(playerObject.name);
        // Debug.Log(GameObject.Find("Player").GetComponent<Player>().jumpCounter);
    }
}

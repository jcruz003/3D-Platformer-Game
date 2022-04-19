using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoarder : MonoBehaviour
{
    public void OnCollisionEnter()
    {
        Debug.Log("Boarder hit!");
    }
}

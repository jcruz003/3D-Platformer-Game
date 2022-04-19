using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevelTrigger : MonoBehaviour
{

    public void OnTriggerEnter()
    {
        Debug.Log("Level Complete!");
    }
}

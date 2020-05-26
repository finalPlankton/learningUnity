using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;

    // This method will trigger if an object hits this object.
    private void OnTriggerEnter(Collider other)
    {
        gameManager.CompleteLevel();
    }
}

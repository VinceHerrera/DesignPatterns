using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnder : MonoBehaviour
{
    /* Vince Herrera */

    // Methods
    private void OnCollisionEnter(Collision collision)
    {
        GameManager.Instance.StartScene();
    }
}

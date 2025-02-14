using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
Name: Vince Herrera
*/

public class Canvasnav : MonoBehaviour
{
    //Methods
    public void LoadNextScene()
    {
        GameManager.Instance.NextScene();
    }
    public void LoadStartScreen()
    {
        GameManager.Instance.StartScene();
        //LoadNextScene(0);
    }
}

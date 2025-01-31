using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
Name: Vince Herrera
*/

public class Canvasnav : MonoBehaviour
{
    //Vars
    [SerializeField]

    //Methods
    public void LoadNextScene(int aIDX)
    {
        SceneManager.LoadScene(aIDX);
    }
    public void LoadStartScreen()
    {
        LoadNextScene(0);
    }
}

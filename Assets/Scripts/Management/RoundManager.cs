using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundManager : MonoBehaviour
{
    //[SerializeField] protected List<BreakableBrick> bricks;
    [SerializeField] protected GameObject canvasScene;



    //Methods

    private void Update()
    {
        EndRound();
    }

    private void Awake()
    {
        RoundManager[] gOs = FindObjectsOfType<RoundManager>();

        if (gOs.Length! > 1)
        {
            Destroy(gameObject);
        }
    }

    /*
    public void RemoveBrick(BreakableBrick bb)
    {
        if (bricks.Count > 0)
        {
            bricks.Remove(bb);
        }
        EndRound();
    }
    */


    protected void EndRound()
    {
        Debug.Log(FindObjectsOfType<BreakableBrick>().Length);
        if (FindObjectsOfType<BreakableBrick>().Length < 1)
        {
            canvasScene.SetActive(true);
        }
    }
}
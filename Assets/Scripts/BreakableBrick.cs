using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableBrick : MonoBehaviour
{
    /*
     * Vince Herrera
     */


    // Vars
    [SerializeField, Range(1, 20)] protected int hitsToBreak;
    [SerializeField, Range(1, 20)] protected int pointValue;
    protected int curHitsToBreak = 0;

    // break emitter
    [SerializeField] ParticleSystem hit_PS;
    [SerializeField] float destroyDelay = 0.1f;
    private void Awake()
    {
        curHitsToBreak= hitsToBreak;
    }
    public void Break(int aDamage)
    {
        curHitsToBreak -= aDamage;
        
        BreakBrick();
    }
    protected void BreakBrick()
    {
        if (curHitsToBreak <= 0)
        {
            //add flare before Destroy
            GameManager.Instance.AddScore(pointValue);
            if (hit_PS != null)
            {
                Debug.Log("Playing Particle System");
                hit_PS.Play();
            }
            Destroy(gameObject, destroyDelay);
        }
    }
    
}



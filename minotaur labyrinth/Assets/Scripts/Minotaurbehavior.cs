using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;


public class Minotaurbehavior : MonoBehaviour
{
    //Animations control
    public AIPath aipath;
    public float xthreshhold;
    public float ythreshhold;
    public Animator animator;
    public float threshholdMultiplier;
    public float minimumthreshhold;
    // Update is called once per frame
    private void Start()
    {
       
    }

    void Update()
    {
        
        //North
        if (aipath.desiredVelocity.x<xthreshhold*threshholdMultiplier && aipath.desiredVelocity.x > (-threshholdMultiplier*xthreshhold) && aipath.desiredVelocity.y > minimumthreshhold)
        {
            animator.SetInteger("Direction", 1);
            Debug.Log("Direction is 1");
            
        }
        //NE
        if (aipath.desiredVelocity.x > minimumthreshhold && aipath.desiredVelocity.y > ythreshhold * threshholdMultiplier)
        {
            animator.SetInteger("Direction", 2);
            Debug.Log("Direction is 2");
        }
        //East
        if (aipath.desiredVelocity.y < ythreshhold * threshholdMultiplier && aipath.desiredVelocity.y > (-threshholdMultiplier * ythreshhold) && aipath.desiredVelocity.x > minimumthreshhold)
        {
            animator.SetInteger("Direction", 3);
            Debug.Log("Direction is 3");

        }
        //SE
        if (aipath.desiredVelocity.x > minimumthreshhold && aipath.desiredVelocity.y < -ythreshhold * threshholdMultiplier)
        {
            animator.SetInteger("Direction", 4);
            Debug.Log("Direction is 4");
        }
        //South
        if (aipath.desiredVelocity.x < xthreshhold * threshholdMultiplier && aipath.desiredVelocity.x > (-threshholdMultiplier * xthreshhold) && aipath.desiredVelocity.y < -minimumthreshhold)
        {
            animator.SetInteger("Direction", 5);
            Debug.Log("Direction is 5");

        }
        //SW
        if (aipath.desiredVelocity.x < -minimumthreshhold && aipath.desiredVelocity.y < -ythreshhold * threshholdMultiplier)
        {
            animator.SetInteger("Direction", 6);
            Debug.Log("Direction is 6");
        }
        //West
        if (aipath.desiredVelocity.y < ythreshhold * threshholdMultiplier && aipath.desiredVelocity.y > (-threshholdMultiplier * ythreshhold) && aipath.desiredVelocity.x < -minimumthreshhold)
        {
            animator.SetInteger("Direction", 7);
            Debug.Log("Direction is 7");
        }
        //NW
        if (aipath.desiredVelocity.x < -minimumthreshhold && aipath.desiredVelocity.y > ythreshhold * threshholdMultiplier)
        {
            animator.SetInteger("Direction", 8);
            Debug.Log("Direction is 8");
        }
    }
}

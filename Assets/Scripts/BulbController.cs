using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulbController : MonoBehaviour
{
    // switchOff reflects whether the switch is on ot off
    

    // switchAnimator will hold the gameobjects Animator
    public Animator bulbAnimator;
    public bool bulbOn;

    void Awake()
    {

        bulbAnimator = gameObject.GetComponent<Animator>();
        turnOff();
    }

    public void turnOn()
    {
        bulbAnimator.SetBool("On", true);
        bulbOn = true;
    }

    public void turnOff()
    {
        bulbAnimator.SetBool("On", false);
        bulbOn = false;
    }
}

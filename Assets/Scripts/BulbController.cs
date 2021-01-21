using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulbController : MonoBehaviour
{
    // switchOff reflects whether the switch is on ot off
    public bool switchOff = true;

    // switchAnimator will hold the gameobjects Animator
    public Animator bulbAnimator;

    void Awake()
    {

        bulbAnimator = gameObject.GetComponent<Animator>();
        turnOff();
    }

    public void turnOn()
    {
        switchOff = false;
        bulbAnimator.SetBool("BulbOff", switchOff);
    }

    public void turnOff()
    {
        switchOff = true;
        bulbAnimator.SetBool("BulbOff", switchOff);
    }
}

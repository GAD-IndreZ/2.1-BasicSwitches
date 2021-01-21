using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulbController : MonoBehaviour
{
    // switchOff reflects whether the switch is on ot off
    private bool switchOff = true;

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

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Someone entered the switch trigger");

        this.turnOn();
    }

    void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("Someone left the switch trigger");

        this.turnOff();
    }
}

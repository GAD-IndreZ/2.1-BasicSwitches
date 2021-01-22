using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * A script that adds the following functionality:
 *   - If a game object enters the "trigger" of the switch then the
 *     the switch is automatically turned on. When you leave the "trigger"
 *     box the switch is automatically turned off.
 */

public class AutoSwitchController : MonoBehaviour
{
    // switchOff reflects whether the switch is on ot off
    private bool switchOff = true;

    // switchAnimator will hold the gameobjects Animator
    private Animator switchAnimator;

    BulbController theBulbController;

    void Awake()
    {
       
        switchAnimator = gameObject.GetComponent<Animator>();
        GameObject theBulb = GameObject.FindGameObjectWithTag("Bulb");

        if (theBulb != null)
        {
            theBulbController = theBulb.GetComponent<BulbController>();
        }
    }

    void Start()
    {
        turnOff();

    }
    public void turnOn()
    {
        switchOff = false;
        switchAnimator.SetBool("SwitchOff", switchOff);
        theBulbController.turnOn();
    }

    public void turnOff()
    {
        switchOff = true;
        switchAnimator.SetBool("SwitchOff", switchOff);

        theBulbController.turnOff();
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


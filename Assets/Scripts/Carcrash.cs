using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// Usage: Put this on a car to have the game end when the player crashes into it


public class Carcrash : MonoBehaviour
{
//public GameObject car;
	public GameObject sprite;
	public Cardriver driverscript;
	public GameObject restartbutton;

	

    void OnTriggerEnter ()
    {
	    Time.timeScale = 0;
	    Crash();
    }

	void Crash()
	{
		sprite.SetActive(true);
		driverscript.enabled = false;
		restartbutton.SetActive(true);
	}
	
}

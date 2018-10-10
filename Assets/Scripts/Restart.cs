using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Usage: Put this on a button to make it restart the game on click
public class Restart : MonoBehaviour 
{
    

	public void OnClickDown()
	{
		SceneManager.LoadScene("SampleScene");
	}

	
}

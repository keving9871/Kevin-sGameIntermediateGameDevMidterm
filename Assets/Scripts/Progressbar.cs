using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Usage: This script fills the progress bar in relation to player clicks
// Intent: This script will make a progress bar on the UI that fills up or drains based on how fast the player clicks a button

public class Progressbar : MonoBehaviour {

    // Variables:
    public float progress;
    public Vector2 position = new Vector2(20, 40);
    public Vector2 size = new Vector2(200, 20);
    public Texture2D progress_empty_image;
    public Texture2D progress_full_image;
    public RigidbodyVehicle carscript;

	void OnGUI()
	{
        GUI.DrawTexture (new Rect (position.x, position.y, size.x, size.y), progress_empty_image);
        GUI.DrawTexture(new Rect(position.x, position.y, size.x * progress, size.y), progress_full_image);
	}

	void Start () 
    {
        progress = 0f;
	}
	
	
	void FixedUpdate () 
    {
        if (progress < 1) 
        {
            progress -= 0.01f;
        }
        progress = Mathf.Clamp01(progress);
       // Mathf.Max(0, Mathf.Min(1, progress));
	}
    public void OnClickDown()
    {

        if (progress >= 1)
        {
            carscript.stalled = false;
           
        }
        else { progress += 0.15f; }

    }

   
}

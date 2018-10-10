using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Usage: Put this on NPC Car's to make them drive along a set route
public class Cardriver : MonoBehaviour
{

	public GameObject Car;
	Vector3  startPoint;

	void Start()
	{
		startPoint = new Vector3(-22f, 3f, -2504.5f);
	}
	
	void Update ()
	{
		Car.transform.Translate(-.5f, 0f, 0f);
		if (Car.transform.position.z <= -3850f)
		{
			Car.transform.position = startPoint;
		}
	}
}

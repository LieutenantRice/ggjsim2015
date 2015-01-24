using UnityEngine;
using System.Collections;

public class s_Time : MonoBehaviour 
{
	//public float f_minutes = 2880.0f;
	public float f_seconds = 172800.0f;
	public float f_gewensteSpeeltijd = 3;

	void Start () 
	{
		f_gewensteSpeeltijd *= 60;
		f_gewensteSpeeltijd = f_seconds / f_gewensteSpeeltijd; // Verhouding tussen echte en fictieve seconden 
	}

	void Update () 
	{
		float dt = Time.deltaTime;
		f_seconds -= dt * f_gewensteSpeeltijd;
	}

	public float getHour()
	{
		float hours = f_seconds / 3600;
		hours = Mathf.Floor (hours);
		return hours;
	}

	public float getMinutes()
	{
		float minutes = Mathf.Floor ((f_seconds % 3600) / 60);
	 	return minutes;
	}
}

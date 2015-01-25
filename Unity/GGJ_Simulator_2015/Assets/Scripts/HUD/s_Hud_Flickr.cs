using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class s_Hud_Flickr : MonoBehaviour
{
  public float SwitchTime = 0.8f;
  private float _nextTime = 0;
  private bool _active = true;
  private RawImage img;
	// Use this for initialization
	void Start ()
	{
	  img = GetComponent<RawImage>();

	}
	
	// Update is called once per frame
	void Update () {
	  if (Time.time > _nextTime)
	  {
	    _nextTime = Time.time + SwitchTime;
	      _active = !_active;
	    img.enabled = _active;
	  }
	}
}

using UnityEngine;
using System.Collections;

public class s_Destroy : MonoBehaviour
{
  public float TTL;
  private float _time = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	  _time += Time.deltaTime;
    if(_time > TTL) Destroy(gameObject);
	}
}

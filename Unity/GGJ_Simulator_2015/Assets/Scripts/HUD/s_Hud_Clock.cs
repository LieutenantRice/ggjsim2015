using UnityEngine;
using System.Collections;

public class s_Hud_Clock : MonoBehaviour
{
  public float totalTime = 172800.0f;
  private s_Time _time;
  private RectTransform _trans;
	// Use this for initialization
	void Start ()
	{
	  _trans = GetComponent<RectTransform>();
    _time = GameObject.FindGameObjectWithTag("Player").GetComponent<s_Time>();
	}
	
	// Update is called once per frame
	void Update () {
    _trans.localRotation = Quaternion.Euler(new Vector3(0,0,360*(_time.f_seconds/totalTime)));
	}
}

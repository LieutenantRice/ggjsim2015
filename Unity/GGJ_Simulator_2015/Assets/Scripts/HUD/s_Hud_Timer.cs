using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class s_Hud_Timer : MonoBehaviour {

  private s_Time _time;
  private Text _label;

	// Use this for initialization
	void Start () {
    _label = GetComponent<Text>();
	  _time = GameObject.FindGameObjectWithTag("Player").GetComponent<s_Time>();
	}
	
	// Update is called once per frame
	void Update ()
	{
    _label.text = _time.getHour().ToString("00") + ":" + _time.getMinutes().ToString("00");
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class s_Hud_glow : MonoBehaviour
{
  public float PulseDuration = 1;
  private Image _image;
  private float _lowerPulseValue = 0.7f;
  private bool _pulsing = false;
  private bool _stopping = false;
  private bool _mostVis ;
  private float _nextTime;

	// Use this for initialization

	void Start ()
	{
	  _image = GetComponent<Image>();
    _image.CrossFadeAlpha(0, 0, true);
	}
	
	// Update is called once per frame
	void Update () {
	  if (_pulsing && Time.time >= _nextTime)
	  {
	    _nextTime = Time.time + PulseDuration;

	    if (_stopping)
	    {
	      _pulsing = false;
        _image.CrossFadeAlpha(0, PulseDuration, false);
	      _mostVis = false;
	      _stopping = false;
	    }
	    else
	    {
	      if (_mostVis)
	      {
	        _image.CrossFadeAlpha(_lowerPulseValue, PulseDuration, false);
	      }
	      else
	      {
          _image.CrossFadeAlpha(1, PulseDuration, false);
	      }
	      _mostVis = !_mostVis;
	    } 
	  }
	}

  public void SetActive(bool active)
  {
    if (active)
    {
      _pulsing = true;
    }
    else
    {
      _stopping = true;
    }
  }
}

using UnityEngine;
using System.Collections;

public class s_Hud_Danger_General : MonoBehaviour {
  StatisticsSet _stats;
  public float foodLimit = 0.15f;
  public float energyLimit = 0.20f;
  public float ProcrLimit = 0.10f;
  public float pissLimit = 0.85f;
  private bool _dangerzone;
  private s_Hud_glow glow;

	// Use this for initialization
	void Start () {
    _stats = GameObject.FindGameObjectWithTag("Player").GetComponent<s_Stats>().Stats;
	  glow = GetComponent<s_Hud_glow>();
	}
	
	// Update is called once per frame
	void Update () {

	  if ( !_dangerzone &&
	    (
	      _stats.food.Value <= foodLimit ||
        _stats.energy.Value <= energyLimit ||
        _stats.procrastination.Value <= ProcrLimit ||
        _stats.piss.Value >= pissLimit
	      )
	    )
	  {
	    _dangerzone = true;
      glow.SetActive(true);
	  }
    else if(_dangerzone && 
      (
        !(_stats.food.Value <= foodLimit) &&
        !(_stats.energy.Value <= energyLimit) &&
        !(_stats.procrastination.Value <= ProcrLimit) &&
        !(_stats.piss.Value >= pissLimit)
      )
      )
    {
      _dangerzone = false;
      glow.SetActive(false);
    }


	}
}

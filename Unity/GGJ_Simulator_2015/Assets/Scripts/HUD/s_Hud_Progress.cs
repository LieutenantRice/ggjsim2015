using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class s_Hud_Progress : MonoBehaviour
{
  public float MaxWidth = 3280;
  public Text Label;
  public bool HasLabel;
  public enum_stat Stat;
  private Statistic _stat;
	// Use this for initialization
	void Start ()
	{
	  switch (Stat )
	  {
      case enum_stat.Progress:
        _stat = GameObject.FindGameObjectWithTag("Player").GetComponent<s_Stats>().Stats.progress;
	      break;
      case enum_stat.Food:
        _stat = GameObject.FindGameObjectWithTag("Player").GetComponent<s_Stats>().Stats.food;
	      break;
      case enum_stat.Energy:
        _stat = GameObject.FindGameObjectWithTag("Player").GetComponent<s_Stats>().Stats.energy;
	      break;
      case enum_stat.Procrasitination:
        _stat = GameObject.FindGameObjectWithTag("Player").GetComponent<s_Stats>().Stats.procrastination;
	      break;
      case enum_stat.Piss:
        _stat = GameObject.FindGameObjectWithTag("Player").GetComponent<s_Stats>().Stats.piss;
	      break;
	  }
	}
	
	// Update is called once per frame
	void Update () {
    GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal,MaxWidth * _stat.Value);
    if (HasLabel) Label.text = _stat.Value.ToString("P1");
	}
}

public enum enum_stat
{
  Progress, 
  Food,
  Energy,
  Procrasitination,
  Piss
}

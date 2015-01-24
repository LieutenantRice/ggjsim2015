using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class s_HudStats : MonoBehaviour {
  public GameObject Prefab;

  private GameObject _ProgressObj;
  private GameObject _EnergyObj;
  private GameObject _FoodObj;
  private GameObject _PissObj;
  private GameObject _ProcrastinationObj;

  private Statistic _ProgressStatistic;
  private Statistic _EnergyStatistic;
  private Statistic _FoodStatistic;
  private Statistic _PissStatistic;
  private Statistic _ProcrastinationStatistic;

	void Start ()
	{
	  StatisticsSet playerStats = GameObject.FindGameObjectWithTag("Player").GetComponent<s_Stats>().Stats;

	  _ProgressStatistic = playerStats.progress;
    _EnergyStatistic = playerStats.energy;
    _FoodStatistic = playerStats.food;
    _PissStatistic = playerStats.piss;
    _ProcrastinationStatistic = playerStats.procrastination;


	  _ProgressObj = (GameObject) Instantiate(Prefab);
    _ProgressObj.transform.SetParent(transform, false);
    _ProgressObj.GetComponent<RectTransform>().anchorMin = new Vector2(0.1f, 0.8f);
    _ProgressObj.GetComponent<RectTransform>().anchorMax = new Vector2(0.1f, 0.8f);
	  _ProgressObj.GetComponent<Text>().text = "Progress";

    _EnergyObj = (GameObject)Instantiate(Prefab);
    _EnergyObj.transform.SetParent(transform, false);
    _EnergyObj.GetComponent<RectTransform>().anchorMin = new Vector2(0.1f, 0.65f);
    _EnergyObj.GetComponent<RectTransform>().anchorMax = new Vector2(0.1f, 0.65f);
    _EnergyObj.GetComponent<Text>().text = "Energy";

    _FoodObj = (GameObject)Instantiate(Prefab);
    _FoodObj.transform.SetParent(transform, false);
    _FoodObj.GetComponent<RectTransform>().anchorMin = new Vector2(0.1f, 0.5f);
    _FoodObj.GetComponent<RectTransform>().anchorMax = new Vector2(0.1f, 0.5f);
    _FoodObj.GetComponent<Text>().text = "Food";

    _PissObj = (GameObject)Instantiate(Prefab);
    _PissObj.transform.SetParent(transform, false);
    _PissObj.GetComponent<RectTransform>().anchorMin = new Vector2(0.1f, 0.35f);
    _PissObj.GetComponent<RectTransform>().anchorMax = new Vector2(0.1f, 0.35f);
    _PissObj.GetComponent<Text>().text = "Piss";

    _ProcrastinationObj = (GameObject)Instantiate(Prefab);
    _ProcrastinationObj.transform.SetParent(transform, false);
    _ProcrastinationObj.GetComponent<RectTransform>().anchorMin = new Vector2(0.1f, 0.2f);
    _ProcrastinationObj.GetComponent<RectTransform>().anchorMax = new Vector2(0.1f, 0.2f);
    _ProcrastinationObj.GetComponent<Text>().text = "Procrastination";
	}
	
	void Update ()
	{
	  _ProgressObj.transform.GetChild(0).GetChild(0).GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 
      120f * _ProgressStatistic.Value );
    
    _EnergyObj.transform.GetChild(0).GetChild(0).GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal,
      120f * _EnergyStatistic.Value);

    _FoodObj.transform.GetChild(0).GetChild(0).GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal,
      120f * _FoodStatistic.Value);

    _PissObj.transform.GetChild(0).GetChild(0).GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal,
      120f * _PissStatistic.Value);

    _ProcrastinationObj.transform.GetChild(0).GetChild(0).GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal,
      120f * _ProcrastinationStatistic.Value);
	}
}

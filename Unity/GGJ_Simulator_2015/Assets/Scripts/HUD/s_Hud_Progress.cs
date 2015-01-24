using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class s_Hud_Progress : MonoBehaviour
{
  public float MaxWidth = 3280;
  public Text Label;
  public bool HasLabel;
  private Statistic _stat;
	// Use this for initialization
	void Start ()
	{
	  _stat = GameObject.FindGameObjectWithTag("Player").GetComponent<s_Stats>().Stats.progress;
	}
	
	// Update is called once per frame
	void Update () {
    GetComponent<RectTransform>().SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal,MaxWidth * _stat.Value);
    if (HasLabel) Label.text = _stat.Value.ToString("P1");
	}
}

using UnityEngine;
using System.Collections;

public class s_cheese : s_Interactable {

  private StatisticsSet stats;

  private void Start()
  {
    crosshair = 2;
    stats = GameObject.FindGameObjectWithTag("Player").GetComponent<s_Stats>().Stats;
  }

  public override void Interact()
  {
    stats.food.Add(0.5f);
    stats.procrastination.Add(0.05f);
    Destroy(gameObject);
  }
  public override void LookAt(bool IsClose)
  {
  }
}

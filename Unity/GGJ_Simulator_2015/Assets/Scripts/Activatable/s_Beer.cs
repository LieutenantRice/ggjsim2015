using UnityEngine;
using System.Collections;

public class s_Beer : s_Interactable {

  private StatisticsSet stats;

  private void Start()
  {
    crosshair = 2;
    stats = GameObject.FindGameObjectWithTag("Player").GetComponent<s_Stats>().Stats;
  }

  public override void Interact()
  {
    stats.food.Add(0.2f);
    stats.piss.Add(0.2f);
    stats.procrastination.Add(0.4f);
    Destroy(gameObject);
  }
}

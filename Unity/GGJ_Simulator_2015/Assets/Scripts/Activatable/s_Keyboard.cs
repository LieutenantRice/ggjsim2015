using UnityEngine;
using System.Collections;

public class s_Keyboard : s_Interactable
{
  private StatisticsSet stats;
  private void Start()
  {
    crosshair = 1;
    stats = GameObject.FindGameObjectWithTag("Player").GetComponent<s_Stats>().Stats;
  }

  public override void Interact()
  {
    stats.progress.Update(1, false);
    stats.procrastination.Add(-0.02f);
  }

  public override void LookAt(bool IsClose)
  {
  }
}

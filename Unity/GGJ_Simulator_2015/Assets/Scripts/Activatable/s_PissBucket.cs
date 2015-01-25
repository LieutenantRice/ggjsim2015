using UnityEngine;
using System.Collections;

public class s_PissBucket : s_Interactable {

  private StatisticsSet stats;
  public Transform ps;

  private void Start()
  {
    crosshair = 5;
    stats = GameObject.FindGameObjectWithTag("Player").GetComponent<s_Stats>().Stats;
  }

  public override void Interact()
  {
    Instantiate(ps, transform.position, Quaternion.identity);
    stats.piss.Add(-0.15f);
  }
  public override void LookAt(bool IsClose)
  {
  }
}

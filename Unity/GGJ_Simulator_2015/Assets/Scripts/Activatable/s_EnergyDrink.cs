using UnityEngine;
using System.Collections;

public class s_EnergyDrink : s_Interactable {

  private StatisticsSet stats;
  public Transform ps;
  private void Start()
  {
    crosshair = 4;
    stats = GameObject.FindGameObjectWithTag("Player").GetComponent<s_Stats>().Stats;
  }

  public override void Interact()
  {
    //Instantiate(ps, transform.position, Quaternion.identity);
    stats.energy.Add(0.4f);
    stats.piss.Add(0.3f);
    Destroy(gameObject);
  }
  public override void LookAt(bool IsClose)
  {
  }
}

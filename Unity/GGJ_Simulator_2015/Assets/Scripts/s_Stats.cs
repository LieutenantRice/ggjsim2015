using UnityEngine;
using System.Collections;

public class s_Stats : MonoBehaviour
{
  public bool Running;
  public float EnergyRunConsumption = 1.5f;
  public StatisticsSet Stats = new StatisticsSet();

  void Update()
  {

    Stats.energy.Update((Running) ? 1 : EnergyRunConsumption);
    Stats.food.Update();
    Stats.procrastination.Update();
    Stats.piss.Update();
  }
}
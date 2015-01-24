using UnityEngine;
using System.Collections;

public class s_Stats : MonoBehaviour
{

  public StatisticsSet Stats = new StatisticsSet();

  void Update()
  {
    Stats.energy.Update();
    Stats.food.Update();
    Stats.procrastination.Update();
    Stats.piss.Update();
  }
}
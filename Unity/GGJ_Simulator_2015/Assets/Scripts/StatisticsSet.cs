using UnityEngine;
using System.Collections;

public class StatisticsSet
{

  public Statistic energy;
  public Statistic progress;
  public Statistic food;
  public Statistic procrastination;
  public Statistic piss;

  public StatisticsSet()
  {
    energy = new Statistic();
    progress = new Statistic(0, 1, 0, 0.005f);
    food = new Statistic();
    procrastination = new Statistic(0,1,1,0);
    piss = new Statistic(0,1,0.4f,0.01f);
  }

}

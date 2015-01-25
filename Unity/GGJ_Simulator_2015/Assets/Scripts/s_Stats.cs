using UnityEngine;
using System.Collections;

public class s_Stats : MonoBehaviour
{
  public bool Running;
  public float EnergyRunConsumption = 1.5f;
  public StatisticsSet Stats = new StatisticsSet();
  public s_death deathscript;
  public float TimeBeforeDeath;
  private float health = 1;

  void Update()
  {
    
    Stats.energy.Update((Running) ? 1 : EnergyRunConsumption);
    Stats.food.Update();
    Stats.procrastination.Update();
    Stats.piss.Update();
    if (Stats.energy.Value <= 0 || Stats.food.Value <= 0 || Stats.procrastination.Value <= 0 || Stats.piss.Value >= 1)
    {
      health -= Time.deltaTime/TimeBeforeDeath;
    }
    else
    {
      health = 1;
    }
    if (health <= 0)
    {
      
      deathscript.Die();
    }
  }
}
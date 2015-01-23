using UnityEngine;
using System.Collections;

public class Stats : MonoBehaviour
{

  private Statistic energyStatistic = new Statistic();
  private Statistic progressStatistic = new Statistic(0, 1, 0);
  private Statistic foodStatistic = new Statistic();
  private Statistic procrastinationStatistic = new Statistic();
  private Statistic drinkStatistic = new Statistic();

  public Statistic EnergyStatistic
  {
    get { return energyStatistic; }
    set { energyStatistic = value; }
  }

  public Statistic ProgressStatistic
  {
    get { return progressStatistic; }
    set { progressStatistic = value; }
  }

  public Statistic FoodStatistic
  {
    get { return foodStatistic; }
    set { foodStatistic = value; }
  }

  public Statistic ProcrastinationStatistic
  {
    get { return procrastinationStatistic; }
    set { procrastinationStatistic = value; }
  }

  public Statistic DrinkStatistic
  {
    get { return drinkStatistic; }
    set { drinkStatistic = value; }
  }


  private void Update()
  {
    energyStatistic.Update();
    foodStatistic.Update();
    procrastinationStatistic.Update();
    drinkStatistic.Update();
  }
}
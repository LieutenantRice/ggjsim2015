using UnityEngine;
using System.Collections;

public class Stats : MonoBehaviour
{

  private Statistic energyStatistic = new Statistic();
  private Statistic progressStatistic = new Statistic(0, 1, 0,0);
  private Statistic foodStatistic = new Statistic();
  private Statistic procrastinationStatistic = new Statistic();
  private Statistic drinkStatistic = new Statistic();

  public Statistic EnergyStatistic
  {
    get { return energyStatistic; }
  }

  public Statistic ProgressStatistic
  {
    get { return progressStatistic; }
  }

  public Statistic FoodStatistic
  {
    get { return foodStatistic; }
  }

  public Statistic ProcrastinationStatistic
  {
    get { return procrastinationStatistic; }
  }

  public Statistic DrinkStatistic
  {
    get { return drinkStatistic; }
  }


  void Update()
  {
    energyStatistic.Update();
    foodStatistic.Update();
    procrastinationStatistic.Update();
    drinkStatistic.Update();

    if (Input.GetKeyDown("b"))
    {
      Debug.Log("hey");
    }
  }
}
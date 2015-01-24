using UnityEngine;
using System.Collections;

public class Statistic {

  float _minimumValue;
  float _value;
  float _maximumValue;
  float _UpdateRate;


  public float Value
  {
    get { 
      return _value; 
    }
    set
    {
      _value = Mathf.Clamp(value, _minimumValue, _maximumValue);
    }
  }

  public void Update(float multiplier = 1, bool withDeltaTime = true)
  {
    Value += _UpdateRate * ((withDeltaTime)?Time.deltaTime : 1) * multiplier;
  }

  public void Add(float amount)
  {
    Value += amount;
  }

  public Statistic(float minimumValue = 0f, float maximumValue = 1f, float value = 1f, float updateRate = -0.03f )
  {
    _minimumValue = minimumValue;
    _maximumValue = maximumValue;
    _value = value;
    _UpdateRate = updateRate;

  }

}

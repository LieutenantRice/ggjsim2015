using UnityEngine;
using System.Collections;

public class s_Music : s_Interactable
{
  public int Duration;
  public float ProgrestionationBoost ;
  public float MaxRange;
  public float TickDuration;
  public GameObject Screen;

  private StatisticsSet _stats;
  private float _nextTime = 0;
  private Transform _player;
  private bool _playing = false;
  private float _lastTick = 0;

  private void Start()
  {
    crosshair = 3;
    _stats = GameObject.FindGameObjectWithTag("Player").GetComponent<s_Stats>().Stats;
    _player = GameObject.FindGameObjectWithTag("Player").transform;
  }

  public override void Interact()
  {
    if (!_playing )
    {
      _nextTime = Time.time + Duration;
      _playing = true;
      GetComponent<AudioSource>().Play();
    }
  }

  private void Update()
  {
    if (_playing)
    {
      if (Time.time > _lastTick + TickDuration)
      {
        _lastTick = Time.time;
        _stats.procrastination.Add(ProgrestionationBoost*
                                   (1 - ((transform.position - _player.position).magnitude)/MaxRange));
      }

      if (Time.time >= _nextTime)
      {
        _playing = false;
      }
    }
  }
  
}

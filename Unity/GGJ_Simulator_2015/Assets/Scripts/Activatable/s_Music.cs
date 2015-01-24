using UnityEngine;
using System.Collections;

public class s_Music : s_Interactable
{
  public float ProgrestionationBoost ;
  public float TickDuration;
  public GameObject Audio;

  private StatisticsSet _stats;
  private Transform _player;
  private bool _playing = false;
  private MovieTexture _mov;
  private int _timeOut = 0;
  private int _timeOutMax = 5;
  private AudioSource _audioSource;

  private void Start()
  {
    crosshair = 0;
    _stats = GameObject.FindGameObjectWithTag("Player").GetComponent<s_Stats>().Stats;
    _player = GameObject.FindGameObjectWithTag("Player").transform;
    _mov = (MovieTexture) GetComponent<Renderer>().material.mainTexture;
    _mov.loop = true;
    _audioSource = Audio.GetComponent<AudioSource>();
    _audioSource.clip = _mov.audioClip;
  }

  public override void Interact()
  {
  }

  public override void LookAt(bool IsClose)
  {
    _timeOut = _timeOutMax;

  }

  private void Update()
  {
    if (_timeOut > 0)
    {
      _timeOut --;

      if (!_mov.isPlaying)
      {
        _mov.Play();
        _audioSource.Play();
      }
    }
    else
    {
      if (_mov.isPlaying)
      {
        _mov.Pause();
        _audioSource.Stop();
      }
    }


  }
  
}

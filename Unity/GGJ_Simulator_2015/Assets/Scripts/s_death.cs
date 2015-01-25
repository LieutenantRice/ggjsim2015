using UnityEngine;
using System.Collections;

public class s_death : MonoBehaviour
{
  public float TimeBeforeFadeIn = 2;
  public float TimeToFadeIn = 0.5f;
  private bool _dead = false;
  private float _timeOfDeath;
  private CanvasRenderer _renderer;
  public GameObject Text;
	// Use this for initialization
	void Start ()
	{
	  _renderer = GetComponent<CanvasRenderer>();
	  _renderer.SetAlpha(0);
	  Text.SetActive(false);
	}

  public void Die()
  {
    _dead = true;
    _timeOfDeath = Time.time;
    Text.SetActive(true);
  }

	// Update is called once per frame
  private void Update()
  {
    if (_dead)
    {
      if (Time.time > _timeOfDeath + TimeBeforeFadeIn)
      {
        _renderer.SetAlpha(Mathf.Clamp(_renderer.GetAlpha() + Time.deltaTime / TimeToFadeIn, 0, 1));
        Debug.Log("yey");
      }

    }
  }
}

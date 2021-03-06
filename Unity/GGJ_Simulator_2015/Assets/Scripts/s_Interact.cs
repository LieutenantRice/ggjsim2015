﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class s_Interact : MonoBehaviour
{
  public float interactRange = 1;
  private RawImage _crosshair;
  public Texture NoneTexture;

	void Start ()
	{
	  _crosshair = GameObject.FindGameObjectWithTag("Crosshair").GetComponent<RawImage>();
	}

  private bool CastRay(out s_Interactable interactable, out float distance)
  {
    RaycastHit hit ;
    Ray ray = new Ray(Camera.main.transform.position,Camera.main.transform.forward);

    if (Physics.Raycast(ray, out hit) && hit.collider.GetComponent<s_Interactable>() != null)
    {
      
      interactable = hit.collider.GetComponent<s_Interactable>();
      distance = hit.distance;
      return true;
    }
    interactable = null;
    distance = 0;
    return false;
  }

  void Update () {

    setCrosshairUV(0);

    s_Interactable i;
    float distance;
    if (CastRay(out i, out distance))
    {
      i.LookAt((distance <= interactRange));
      if (distance <= interactRange)
      {
      
        if (Input.GetButtonDown("Interact"))
        {
          i.Interact();
        }
      setCrosshairUV(i.Crosshair);
    }
  }
  }

  private void setCrosshairUV(int id)
  {
    _crosshair.uvRect = new Rect(0.1f*id ,0f ,0.1f, 1f);
  }

}

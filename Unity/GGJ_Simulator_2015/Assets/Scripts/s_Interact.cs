using UnityEngine;
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

  private bool CastRay(out s_Interactable interactable)
  {
    RaycastHit hit ;
    Ray ray = new Ray(Camera.main.transform.position,Camera.main.transform.forward);

    if (Physics.Raycast(ray, out hit, interactRange) && hit.collider.GetComponent<s_Interactable>() != null)
    {
      
      interactable = hit.collider.GetComponent<s_Interactable>();
      return true;
    }
    interactable = null;
    return false;
  }

  void Update () {
    s_Interactable i;
    if (CastRay(out i))
    {
      if (Input.GetButtonDown("Interact"))
      {
        i.Interact();
      }
      setCrosshairUV(i.Crosshair);
    }
    else
    {
      setCrosshairUV(0);
    }
  }

  private void setCrosshairUV(int id)
  {
    _crosshair.uvRect =
      new Rect(0.1f*id ,0f ,0.1f, 1f);
  }

}

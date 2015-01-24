using UnityEngine;
using System.Collections;

public class s_Interact : MonoBehaviour
{
  public float interactRange = 1;

	void Start () {
	
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

    }
	  

	}

}

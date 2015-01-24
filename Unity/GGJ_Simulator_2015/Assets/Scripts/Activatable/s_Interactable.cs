using UnityEngine;
using System.Collections;

public abstract class s_Interactable : MonoBehaviour
{
  protected int crosshair;

  public int Crosshair {
    get { return crosshair; }
  }
  public abstract void Interact();
}

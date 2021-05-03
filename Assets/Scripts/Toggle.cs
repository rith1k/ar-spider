using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toggle: MonoBehaviour {

  [SerializeField] public CanvasGroup Canvas01;
  private bool toggle = false; // global variable default is off

  public void changeToggleStateOn() {

    if (!toggle) {
      Canvas01.alpha = 1f;
      Canvas01.interactable = true;
      Canvas01.blocksRaycasts = true;
      toggle = true;

    } else {
      Canvas01.alpha = 0f;
      Canvas01.interactable = false;
      Canvas01.blocksRaycasts = false;
      toggle = false;
    }
  }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class AnimateSpiders: MonoBehaviour {
  private string currentAnimaton;
  GameObject arObject;
  private bool toggle = false; // global variable default is off
  public Animator animator;
  void Start() {
    arObject = GameObject.FindGameObjectWithTag("Spider");
  }

  public void startAttack() {
      ChangeAnimationState("Attack");
  }

  public void startDeath() {
    ChangeAnimationState("Death");
  }

  public void startHit() {
    ChangeAnimationState("Hit");
  }

  public void startJump() {
    ChangeAnimationState("Jump");
  }

  void ChangeAnimationState(string newAnimation) {
    if (currentAnimaton == newAnimation) return;
    arObject.GetComponent<Animator>().Play(newAnimation);
    animator.Play(newAnimation);
    currentAnimaton = newAnimation;
  }

}
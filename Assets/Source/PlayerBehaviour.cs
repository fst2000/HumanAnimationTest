using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] JoystickController controller;
    Event updateEvent;
    IAnimator animator;
    void Start()
    {
        updateEvent = new Event();
        animator = new HumanWalkAnimator(updateEvent, gameObject.GetComponent<Animator>(), controller);
    }
    void Update()
    {
        updateEvent.Call();
    }
}

using UnityEngine;
public class HumanWalkAnimator : IAnimator
{
    Animator animator;
    IController controller;
    public HumanWalkAnimator(IEvent updateEvent, Animator animator, IController controller)
    {
        updateEvent.Subscribe(Update);
        this.animator = animator;
        this.controller = controller;
        animator.CrossFade("WalkBlend", 0.25f);
    }
    void Update()
    {
        animator.SetFloat("WalkBlendX", controller.Input().x);
        animator.SetFloat("WalkBlendY", controller.Input().y);
    }

}
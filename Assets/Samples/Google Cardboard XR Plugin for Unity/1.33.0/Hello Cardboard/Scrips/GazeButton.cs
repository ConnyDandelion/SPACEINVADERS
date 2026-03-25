using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class GazeButton : MonoBehaviour
{
    [SerializeField]
    private UnityEvent onPointerEnter;
    [SerializeField]
    private UnityEvent onPointExit;
    [SerializeField]
    private UnityEvent onPointerClick;
    [SerializeField]
    private string onPointerEnterAnitationName;
    [SerializeField]
    private string onPointExitAnimationName;
    [SerializeField]
    private string onPointerClickAnimationName;
    private Animator animator;
    public void OnPointerEnter()
    {
        animator.Play(onPointerEnterAnitationName);
        onPointerEnter.Invoke();
    }
    public void OnPointerExit()
    {
       animator.Play(onPointExitAnimationName);
       onPointExit.Invoke(); 
    }
    public void OnPointerClick()
    {
        animator.Play(onPointerClickAnimationName);
        onPointerClick.Invoke();
    }
}

using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class tankcontroller : MonoBehaviour
{

    Vector2 move = Vector2.zero;

    public void OnMove(InputValue valiue)
    { 
        Animator anim = GetComponent<Animator>();
        move = valiue.Get<Vector2>();
        if (move.magnitude > 0.1f)
        {
            
            anim.SetBool("moving", true);
        }
        else
        {
            
            anim.SetBool("moving", false);
        }
    }
    public void onjump(InputValue valiue)
    {


        Animator anim = GetComponent<Animator>();
        anim.SetBool("moving", true);
    }
}

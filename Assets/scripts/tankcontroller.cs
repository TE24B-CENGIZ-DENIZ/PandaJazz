using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class tankcontroller : MonoBehaviour
{

    Vector2 move = Vector2.zero;

    [SerializeField]
    float rotationspeed = 20;

    [SerializeField]
    float speedofwalk= 1.4f;


    public void Update()
    {
        Vector3 mv = Vector3.forward* speedofwalk * move.y;
        transform.Translate(mv * Time.deltaTime);

        float angle= rotationspeed* move.x;
        transform.Rotate(Vector3.up, angle*Time.deltaTime);

    }
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
    public void OnJump(InputValue valiue)
    {


        Animator anim = GetComponent<Animator>();
        anim.SetBool("moving", true);
    }
}

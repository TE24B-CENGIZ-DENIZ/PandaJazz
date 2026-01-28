using UnityEngine;
using UnityEngine.InputSystem;
public class normalcontroller : MonoBehaviour
{

    Vector2 move = Vector2.zero;

    [SerializeField]
    float speed = 1.4f;

    void Update()
    {
        Vector3 mv = Camera.main.transform.forward * move.y + Camera.main.transform.right * move.x;


        mv.y = 0;
        mv.Normalize();


        transform.Translate(mv * Time.deltaTime * speed);

        GameObject model = transform.GetChild(0).gameObject;
        if (mv.magnitude > 0.1f)
        {
            model.transform.forward = mv;
        }


    }
    public void OnMove(InputValue valiue)
    {
        Animator anim = GetComponentInChildren<Animator>();
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

}

using UnityEngine;
using UnityEngine.InputSystem;

public class lookcontroller : MonoBehaviour
{
    Vector2 lookinpt;
    float xrot= 0;
    Camera head;
    
    [SerializeField]
    Vector2 senciv= Vector2.one;
    void Start()
    {
       Cursor.lockState = CursorLockMode.Locked;
       head = GetComponentInChildren<Camera>();
    }

    void Update()
    {
     xrot += lookinpt.y * senciv.y;
     xrot= Mathf.Clamp(xrot,-90, 90);

     head.transform.localEulerAngles = new(
        xrot, 0, 0
     );

     transform.Rotate(Vector3.up, lookinpt.x*senciv.x);   
    }
    void OnLook(InputValue val)
    {
        lookinpt = val.Get<Vector2>();
    }
}

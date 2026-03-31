
using UnityEngine;

public class gazecontroller : MonoBehaviour
{
   Camera head;

    void Start()
    {
        head = GetComponentInChildren<Camera>();
        
    }

    void OnInteract()
    {
        RaycastHit hit;
        if (Physics.Raycast(
           head.transform.position,
           head.transform.forward,
           out hit,
           5
        ))
        {
            print(hit.transform.name);
            hit.transform.SendMessage("Press", SendMessageOptions.DontRequireReceiver);
        }

      
    }
   

}

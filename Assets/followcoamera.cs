using UnityEngine;

public class followcoamera : MonoBehaviour
{
   
    [SerializeField]
    GameObject target;

    
    void Update()
    {
        transform.LookAt(target.transform);
    }
}

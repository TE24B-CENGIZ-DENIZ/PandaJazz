using Unity.VisualScripting;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
  
    GameObject target;

    [SerializeField]
    float EnemySpeed = 5;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
    }

   
    void Update()
    {

       transform.position = Vector3.MoveTowards(transform.position, target.transform.position, EnemySpeed);
    }

}

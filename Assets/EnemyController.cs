using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
  
    GameObject target;

    float TimeToWait= 2;
    float TimeToFire = 0 ;

    [SerializeField]
    float EnemySpeed = 5;

    [SerializeField]
    GameObject bulletprefab;

   

    void Start()
    {
       target = GameObject.FindGameObjectWithTag("Player");
       
    }

    

    void Update()
    {

       transform.position = Vector3.MoveTowards(transform.position, target.transform.position, EnemySpeed);
       TimeToFire += Time.deltaTime;

        if (TimeToFire > TimeToWait)
        {
           
            Instantiate(bulletprefab, transform.position, Quaternion.identity);
            TimeToFire = 0;
        }
        
       
    }

}

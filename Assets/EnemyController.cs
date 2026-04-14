using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField]
    GameObject target;
    
    [SerializeField]
    float EnemySpeed = 5;

    // Update is called once per frame
    void Update()
    {
        
        if (target.transform.position.x < transform.position.x)
        {

            Vector3 movement = Vector3.left * EnemySpeed * Time.deltaTime;
            transform.Translate(movement);
        
        }
        else
        {
            Vector3 movement = Vector3.right * EnemySpeed * Time.deltaTime; 
            transform.Translate(movement);
                                                                                                    // dog water code lmao

        }

    }
}

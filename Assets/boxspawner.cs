using UnityEngine;

public class boxspawner : MonoBehaviour
{
   [SerializeField]
    GameObject cubeprefab;

    float timesincelastcubespawn = 0;

    float timebetweenencubespawn = 3;

    void Start()
    {
        // Vector3 position = new();
        // position.x = 0;
        // position.y = 0;
        // position.z = 0;

        // transform.position = position;
    }


    void Update()
    {
        timesincelastcubespawn += Time.deltaTime;
        if(timesincelastcubespawn> timebetweenencubespawn)
        {
            Instantiate(cubeprefab, transform.position, Quaternion.identity);
            timesincelastcubespawn = 0;
        }
    }
}

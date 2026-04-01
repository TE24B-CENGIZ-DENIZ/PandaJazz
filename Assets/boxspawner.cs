using UnityEngine;

public class boxspawner : MonoBehaviour
{
   [SerializeField]
    GameObject cubeprefab;

    float timesincelastcubespawn = 0;

    float timebetweenencubespawn = 3;

    void Start()
    {
        Vector3 position = new();
        position.x = Random.Range(10, 30);
        position.y = Random.Range(1, 4);
        position.z = Random.Range(10, 30);

        transform.position = position;
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

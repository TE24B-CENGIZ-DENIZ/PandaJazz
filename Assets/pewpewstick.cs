using UnityEngine;

public class pewpewstick : MonoBehaviour
{
    [SerializeField]
    GameObject bulletPrefab;

    [SerializeField]
    float timebetweenshot= 1;
    float timerforshot=0 ;
    Transform spawnpoint;



    void Start()
    {
        spawnpoint = transform.GetChild(0).transform;
    }

    public void fire()
    {
        if(timerforshot > timebetweenshot)
        {
            Instantiate(bulletPrefab, spawnpoint.position, spawnpoint.rotation);
            timerforshot=0;
        }
     
      
    }

    void Update()
    {
        timerforshot += Time.deltaTime;
        
        // fire();
    }
}

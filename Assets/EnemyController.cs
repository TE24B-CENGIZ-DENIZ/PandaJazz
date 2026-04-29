using System;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyController : MonoBehaviour
{

    GameObject target;

    float TimeToWait = 2;
    float TimeToFire = 0;

    [SerializeField]
    float EnemySpeed = 5;

    [SerializeField]
    GameObject bulletprefab;



    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        AudioSource speaker = GetComponent<AudioSource>();
        speaker.Play();
    }


    void Update()
    {

        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, EnemySpeed);
        TimeToFire += Time.deltaTime;
        transform.Rotate(0, .7f, 0);







    }

    void FixedUpdate()
    {
        if (TimeToFire > TimeToWait)
        {

            Instantiate(bulletprefab, transform.position, Quaternion.identity);
            TimeToFire = 0;
        }

    }

}

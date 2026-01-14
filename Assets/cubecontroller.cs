using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class cubecontroller : MonoBehaviour
{

    void Start()
    {
        GameObject[] cylinders = GameObject.FindGameObjectsWithTag("cyl");


        for (int i = 0; i < cylinders.Length; i++)
        {
            if (i % 2 == 0)
            {
                Renderer r = cylinders[i].GetComponent<Renderer>();
                r.material.color = new Color(0, 0, 1);
            }
            else
            {
                Renderer r = cylinders[i].GetComponent<Renderer>();
                r.material.color = new Color(1, 0, 0);
            }

        }

    }

    void Update()
    {

    }
}


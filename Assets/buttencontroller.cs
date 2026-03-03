using System.IO.IsolatedStorage;
using UnityEngine;

public class buttencontroller : MonoBehaviour
{
    public void Press()
    {
        print("aaa");




        GetComponent<Renderer>().material.color = Color.blue;
    }
}

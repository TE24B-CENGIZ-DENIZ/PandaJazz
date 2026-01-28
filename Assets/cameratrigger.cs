using UnityEngine;

public class cameratrigger : MonoBehaviour
{
    [SerializeField]
    Camera cam;

    void OnTriggerEnter(Collider other)
    {
        GameObject[] cameras = GameObject.FindGameObjectsWithTag("MainCamera");

        foreach (GameObject obj in cameras)
        {
            obj.SetActive(false);
        }
        cam.gameObject.SetActive(true);
        print("hi");
    }
}

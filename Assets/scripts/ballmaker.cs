using Unity.Mathematics;
using UnityEngine;

public class ballmaker : MonoBehaviour
{
    [SerializeField]
    GameObject ballprefab;
    void FixedUpdate()
    {
        Instantiate(ballprefab, transform.position, Quaternion.identity);
    }
}

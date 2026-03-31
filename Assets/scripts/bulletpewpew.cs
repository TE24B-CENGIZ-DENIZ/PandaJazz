using UnityEngine;

public class bulletpewpew : MonoBehaviour
{

    [SerializeField]
    float wee = 10f;
    void Start()
    {
        Destroy(this.gameObject, 5);
        GetComponent<Rigidbody>().AddForce(transform.forward*1000);
    }


    void Update()
    {
        // transform.Translate(Vector3.forward* Time.deltaTime*wee);


    }
}

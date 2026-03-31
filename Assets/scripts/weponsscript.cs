using UnityEngine;


public class weponsscript : MonoBehaviour
{

    void OnAttack()
    {
        pewpewstick pewpewstick= GetComponentInChildren<pewpewstick>();

        pewpewstick.fire();
    }
}

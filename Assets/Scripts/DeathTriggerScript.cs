using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTriggerScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "EricHead")
        {
            Destroy(other.gameObject.transform.parent.parent.gameObject);

            if(DayCycle.speed<0.5) DayCycle.speed += 0.05f;
        }
    }
}

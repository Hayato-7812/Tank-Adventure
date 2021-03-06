using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("OutZone"))
        {
            Destroy(this.gameObject);
        }
        if (other.CompareTag("Shell"))
        {
            Destroy(other.gameObject);
        }

    }
}

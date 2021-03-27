using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCManager : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Shell"))
        {
            // EnemyShotShellが当たった時にはEnenyShellを破壊する
            Destroy(other.gameObject);
        }
    }
}

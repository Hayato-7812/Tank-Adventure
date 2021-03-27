using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellManager : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("EnemyShell"))
        {
            // EnemyShotShellが当たった時にはEnenyShellを破壊する
            Destroy(other.gameObject);
        }
    }
}


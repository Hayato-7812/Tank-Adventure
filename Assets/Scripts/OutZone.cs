using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OutZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            // 1.5秒後に「GoToGameOver()」メソッドを実行する。
            Invoke("GoToGameOver", 0.5f);

        }
    }

    private void GoToGameOver()
    {
        SceneManager.LoadScene("GameOver");

    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyShell : MonoBehaviour
{
    // public GameObject effectPrefab;
    // ★★追加
    // 2種類目のエフェクトを入れるための箱
    // public GameObject effectPrefab2;
    public AudioClip destroySound;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Shell"))
        {
            Destroy(other.gameObject);

            // もう１種類のエフェクを発生させる。
            // GameObject effect2 = Instantiate(effectPrefab2, transform.position, Quaternion.identity);
            // Destroy(effect2, 2.0f);

            Destroy(this.gameObject);
            AudioSource.PlayClipAtPoint(destroySound, transform.position);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOb : MonoBehaviour
{
    // public GameObject effectPrefab;
    // ★★追加
    // 2種類目のエフェクトを入れるための箱
    // public GameObject effectPrefab2;
    public int objectHP;
    public AudioClip damageSound;
    public AudioClip destroySound;
    public GameObject itemPrefab;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Shell"))
        {
            // ★★追加
            // オブジェクトのHPを１ずつ減少させる。
            objectHP -= 1;

            // ★★追加
            // もしもHPが0よりも大きい場合には（条件）
            if (objectHP > 0)
            {
                Destroy(other.gameObject);
                // GameObject effect = Instantiate(effectPrefab, transform.position, Quaternion.identity);
                // Destroy(effect, 2.0f);
                AudioSource.PlayClipAtPoint(damageSound, transform.position);

            }
            else
            { // ★★追加  そうでない場合（HPが0以下になった場合）には（条件）
                Destroy(other.gameObject);

                // もう１種類のエフェクを発生させる。
                // GameObject effect2 = Instantiate(effectPrefab2, transform.position, Quaternion.identity);
                // Destroy(effect2, 2.0f);

                Destroy(this.gameObject);
                AudioSource.PlayClipAtPoint(destroySound, transform.position);

                // ★改良
                // アイテムの出現場所を調整する。（地面に埋まっているので、Y軸を調整する。）
                Vector3 pos = transform.position;
                Instantiate(itemPrefab, new Vector3(pos.x, pos.y + 1, pos.z), new Quaternion(0f, 90f, 90f, 1.0f));
            }


        }
    }
}
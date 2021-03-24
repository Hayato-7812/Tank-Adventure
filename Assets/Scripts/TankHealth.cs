using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;
public class TankHealth : MonoBehaviour
{
    // public GameObject effectPrefab1;
    // public GameObject effectPrefab2;
    public int tankHP;

    public AudioClip TankdamageSound;
    public AudioClip TankdestroySound;



    public void OnTriggerEnter(Collider other)
    {
        // もしもぶつかってきた相手のTagが”EnemyShell”であったならば（条件）
        if (other.gameObject.tag == "EnemyShell")
        {
            // HPを１ずつ減少させる。
            tankHP -= 1;

            // ぶつかってきた相手方（敵の砲弾）を破壊する。
            Destroy(other.gameObject);

            if (tankHP > 0)
            {
                // GameObject effect1 = Instantiate(effectPrefab1, transform.position, Quaternion.identity);
                // Destroy(effect1, 1.0f);
                AudioSource.PlayClipAtPoint(TankdamageSound, transform.position);
                // LifeGauge.SetLifeGauge(tankHP);

            }
            else
            {
                // GameObject effect2 = Instantiate(effectPrefab2, transform.position, Quaternion.identity);
                // Destroy(effect2, 1.0f);

                // プレーヤーを破壊する。
                // Destroy(gameObject);

                // ★追加
                // プレーヤーを破壊せずに画面から見えなくする（ポイント・テクニック）
                // プレーヤーを破壊すると、その時点でメモリー上から消えるので、以降のコードが実行されなくなる。
                this.gameObject.SetActive(false);
                AudioSource.PlayClipAtPoint(TankdestroySound, transform.position);
                // LifeGauge.SetLifeGauge(tankHP);


                // ★追加
                // 1.5秒後に「GoToGameOver()」メソッドを実行する。
                Invoke("GoToGameOver", 1.5f);


            }
        }
    }
    // ★追加
    void GoToGameOver()
    {
        SceneManager.LoadScene("GameOver");

    }

}
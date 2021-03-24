using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void OnClickRestartButton()
    {
        Debug.Log("Restart");  // ログを出力
        SceneManager.LoadScene("Main");
    }

    public void OnClickTitleButton()
    {
        Debug.Log("GoToTitle");  // ログを出力
        SceneManager.LoadScene("Title");
    }
}

using UnityEngine;
using System.Collections; // 引用 系統.集合 包含協同程序

/// <summary>
/// 認識協同程序
/// </summary>
public class LearnCoroutine : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(Text());             // 啟動協同程序(協同程序())
        StartCoroutine(TestWithLoop());
    }
    // 定義協同程序
    // 傳回類型 IEnumerator
    private IEnumerator Text()
    {
        print("這是第一段文字訊息");
        yield return new WaitForSeconds(1); // 等待秒數
        print("這是第二段文字訊息");
        yield return new WaitForSeconds(2);
        print("這是第三段文字訊息");
    } 

    private IEnumerator TestWithLoop()
    {
        for (int i = 0; i < 50; i++)
        {
            print("數字 :" + i);
            yield return new WaitForSeconds(0.1f);
        }
    }
}

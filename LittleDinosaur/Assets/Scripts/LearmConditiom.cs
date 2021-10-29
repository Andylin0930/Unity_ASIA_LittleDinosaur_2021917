
using UnityEngine;
/// <summary>
/// 認識判斷式 (條件式)
/// </summary>
public class LearmConditiom : MonoBehaviour
{
    public bool OpenDoor;
    public int score = 70;
    public string weapon = "刀子";

    //開始事件 : 播放遊戲執行一次
    private void Start()
    {
        #region 判斷式 if
        // 語法 :
        // 當布林值為 true 會執行 if 的 {}
        // if ( 布林值 ) { 程式內容 }
        if (true)
        {
            print("認識判斷式 if ");
        }
        // 當布林值為 true 會執行 if 的 {}
        // 當布林值為 false 會執行 elsa 的 {}
        // if ( 布林值 ) { 程式內容 }
        // elsa { 程式內容 }
        if (OpenDoor)
        {
            print("開門 ! ");
        }
        else
        {
            print("關門 ! ");
        }
        #endregion

    }
    //更新事件 : 約一表60次 (60 FPS)
    private void Update()
    {
        print("持續執行~");

        #region 判斷式 if
        // 否則 如果 elae if ( 布林值 ) { 程式內容 } if 下方 elae 上方 無數量限制
        // 如果 分數 >= 60 及格
        // 如果 分數 >= 60 但是 >= 40 補考
        // 否則 就 不及格
        if (score >= 60)
        {
            print("及格~");
        }
        else if (score >= 40)
        {
            print("補考~");
        }
        else
        {
            print("不及格~");
        }
        #endregion

        #region
        // switch ( 值 )
        // {
        //   case "刀子":
        //      攻擊力 10 ;
        //      break; 
        //    case "大劍":
        //      攻擊力 100 ;
        //    default:
        //       這不是武器;
        //      break; 
        // }

        switch (weapon)
        {
            case "刀子":
                print("攻擊力 10 ");
                break;
            case "大劍":
                print("攻擊力 100 ");
                break;
            default:
                print("這不是武器");
                break;
        }
        #endregion
    }
}

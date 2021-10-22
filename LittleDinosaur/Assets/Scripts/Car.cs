using UnityEngine;   //引用 Unity 引擎命名空間:可以使用此空間的 API

// 單行註解
// Andy 2021 10 22 
// class 類別:一個物件的藍圖
// 語法:類別 類別名稱 { 類別內容 (類別成員) }
// 此類別要在 Unity 內使用必須繼承 MonoBehaviour
public class Car : MonoBehaviour 
{
    #region 欄位語法及四大常用類型
    // 欄位 Filed : 保存各種類型資料
    // 語法 : 修飾詞 資料類型 欄位名稱 指定 預設值 結束符號
    //  四大常用類型
    // 整  數:儲存沒有小數點的正負整數 - int
    // 浮點數:儲存帶有小數點的正負整數 - float
    // 字  串:儲存文字資訊            - string
    // 布林值:是與否 true、false      -bool
    // 修飾詞
    // 私人:其他類別不能存取、不顯示 private (預設值)
    // 空開:其他類別可以存取、顯  示 publiv
    // 欄位屬性 Attritube
    // 語法: [屬性名稱(值)]
    // 1. 標題 Header(字串)
    // 2. 提示 Tooltip(字串) 
    // 3. 範圍 Range(最大值、最小值) - 僅適用設值類型 int float
    [Header("CC數"), Range(1000, 3000)]
    public int cc = 1000;
    [Header("重量"), Range(1, 10)]
    public float weight = 3.5f;
    [Header("品牌名稱")  ,Tooltip("車子品牌")]
    public string brand = "藍寶堅尼";
    [Header("是否有天窗")]
    public bool hasSkyWindows = true;
    #endregion

    #region 認識 Unity 內資料類型
    // 顏色、向量 (座標)、按鍵、遊戲物件、元件
    public Color color;
    public Color cololRed = Color.red;
    public Color cololRyellow = Color.yellow;
    public Color cololCustom1 = new Color(0, 0, 1);
    public Color cololCustom2 = new Color(1, 0, 1, 0.5f);
    // 向量2 ~ 4 Vector
    public Vector2 v2;
    public Vector2 v2one = Vector2.one;
    public Vector2 v2Right = Vector2.right;
    public Vector2 v2left = Vector2.left;
    public Vector2 v2Custom = new Vector2(1, 2);
    public Vector3 v3Custom = new Vector3(1, 2, 3);
    // 按鍵 keycode 
    public KeyCode keycode;
    public KeyCode keycodeMouseLeft = KeyCode.Mouse0;
    public KeyCode keycodeSpace = KeyCode.Space;
    // 遊戲物件 GameObject
    public GameObject goCamera;
    public GameObject goCar;
    // 元件 Component 
    public Transform traCamera;
    public Camera cam;
    public SpriteRenderer apr;
    #endregion

    #region 事件 : 程式入口
    // 開始事件 : 遊戲撥放時執行一次
    private void Start()
    {
        // 呼叫方法 : 方法名稱();
        Test();
        Drive80();
        Drive100();
        Drive(120);    //呼叫時填入的稱為:引數
        float w99 = ConverWeight(9.9f);
        print("9.9 轉換 : " + w99);

        print("重量轉換:" + ConverWeight(weight));
    }
    #endregion

    #region 方法語法
    // 方法 : 保存程式內容的區塊、演算法、陳述式
    // 語法 : 修飾詞 傳回類型 方法名稱 (參數1，參數2 ... 參數N) { 程式內容 }
    // void 無傳回 : 使用方法時不會有回傳資料
    // 自訂方法 : 不會執行 必須呼叫才會執行 
    private void Test()
    {
        // 輸出(訊息) - 將訊息輸出至 Unity 儀表板 Console
        print("嗨囉，必取");
    }

    private void Drive80()
    {
        print("開車時速:" + 80);
        print("音效:咻咻咻");
        
    }

    private void Drive100()
    {
        print("開車時速:" + 100);
        print("音效:咻咻咻");
    }

    // 參數語法 : 資料類型 參數名稱
    private void Drive(int speed)
    {
        print("開車時速:" + speed);
        print("音效:咻咻咻");


    }

    private float ConverWeight(float setweight)
    {
        return setweight * 50; 
    }
    #endregion
}
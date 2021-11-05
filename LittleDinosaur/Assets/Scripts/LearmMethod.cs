using UnityEngine;

/// <summary>
///  學習非靜態方法
/// </summary>
public class LearmMethod : MonoBehaviour
{
    // 非靜態方法使用方式
    // 1. 定義一個欄位 : 用於儲存實體物件
    // 2. 欄位資料類型必須與享存取的非靜態屬性類別相同
    // 3. 欄位必須存放實體物件 (將物件拖曳之欄位內)
    public Transform traObject;
    public Rigidbody2D rig;

    private void Start()
    {
        // 非靜態方法
        // 呼叫方法
        // 語法 : 欄位名稱.非靜態方法名稱(對應的引數);
        traObject.Rotate(0, 0, 10);
    }

    private void Update()
    {
        traObject.Rotate(0, 0, 10);
        rig.AddForce(new Vector2(0, 30));
    }
}

using UnityEngine;

/// <summary>
///  �ǲ��R�A�ݩ� Static Property
/// </summary>
public class LearnPrppertyStatic : MonoBehaviour
{
    private void Start()
    {
        // �R�A�ݩ�
        // ���o Get
        // �y�k : ���O�W��.�R�A�ݩʦW��
        print("�H���� : " + Random.value);
        print("�Ҧ���v���ƶq : " + Camera.allCamerasCount);
        // �]�w Set - ����� Read Only �ݩʳ]�w
        // �y�k : ���O�W��.�R�A�ݩʦW�� ���w �� ;
        Time.timeScale = 0.5f;
        Cursor.visible = false;

        // Random.value = 0.5f;    // Read Only ����]�w

    }
}

using UnityEngine;

/// <summary>
/// �ǲ߰}�C Array
/// </summary>
public class LearmArray : MonoBehaviour
{
    #region �}�C
    // �T�ӹD����� : 100, 200, 300
    public int priceA = 100;
    public int priceB = 200;
    public int priceC = 300;

    // �}�C�S�� : �x�s�ۦP�������
    // �y�k :
    // �׹��� ������� [] �}�C�W�� ���w �� �F
    public int[] pricese;

    // �}�C��l��
    // �Ĥ@�� : ���w�}�C�ƶq
    public int[] scores = new int[5];
    // �ĤG�� : ���w�}�C��
    public string[] props = { "����", "�Ť�", "����" };

    public int[] levels = new int[10];

    private void Start()
    {
        // ���o�}�C��� Get
        // �y�k : �}�C�W��[�s��] - �s���q�s�}�l
        print("�ĤT����� :" + props[2]);
        // ���o�}�C��� Set
        // �y�k : �}�C�W��[�s��] ���w �� �F
        props[1] = "�_��";
        print("�ĤG����� :" + props[1]);

        // �}�C���ƶq
        print("���Ű}�C���ƦC :" + levels.Length);
        for (int i = 0; i < levels.Length; i++)
        {
            levels[i] = (i + 1);
        }
    }
    #endregion


}

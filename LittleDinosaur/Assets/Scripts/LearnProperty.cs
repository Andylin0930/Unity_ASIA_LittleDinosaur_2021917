using UnityEngine;

/// <summary>
///  �ǲ߫D�R�A�ݩ�
/// </summary>
public class LearnProperty : MonoBehaviour
{
    // �D�R�A�ݩʨϥΤ覡
    // 1. �w�q�@����� : �Ω��x�s���骫��
    // 2. ��������������P�ɦs�����D�R�A�ݩ����O�ۦP
    // 3. ��쥲���s����骫�� (�N����즲����줺)
    public Transform traA;
    public Camera camA;
    
    private void Start()
    {
        // ���o Get
        // �y�k�G���W��.�D�R�A�ݩʦW��
        print("A ���󪺮y�� :" + traA.position);
        print("A ��v���`�� : " + camA.depth);
        // �]�w Set
        // �y�k :�@���W��.�D�R�A�ݩʦW�١@���w�@�ȡF
        camA.depth = 9.9f;
        traA.position = new Vector3(-7, 3);

    }
}

using UnityEngine;
using System.Collections; // �ޥ� �t��.���X �]�t��P�{��

/// <summary>
/// �{�Ѩ�P�{��
/// </summary>
public class LearnCoroutine : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(Text());             // �Ұʨ�P�{��(��P�{��())
        StartCoroutine(TestWithLoop());
    }
    // �w�q��P�{��
    // �Ǧ^���� IEnumerator
    private IEnumerator Text()
    {
        print("�o�O�Ĥ@�q��r�T��");
        yield return new WaitForSeconds(1); // ���ݬ��
        print("�o�O�ĤG�q��r�T��");
        yield return new WaitForSeconds(2);
        print("�o�O�ĤT�q��r�T��");
    } 

    private IEnumerator TestWithLoop()
    {
        for (int i = 0; i < 50; i++)
        {
            print("�Ʀr :" + i);
            yield return new WaitForSeconds(0.1f);
        }
    }
}

using UnityEngine;

/// <summary>
/// �ǲ߹B���
/// 1. ���w =
/// 2. �ƾ�  + - * / ���W ++ �B ���� --
/// 3. ��� > < >= <= == !=
/// 4. �޿� �åB && �Ϊ� || �A�� !
/// </summary>
public class NewBehaviourScript : MonoBehaviour
{
    #region ���ƹB���
    // ���w�B���S��
    // ���w�B��ȥ�����k��A���w������
    public int number = 10;  // �N�Ʀr 10 ���w�� number

    public float numberA = 10;
    public float numberB = 3;
    public int numberC = 30;
    public int numberD = 5;

    public int numberE = 9;
    public int numberF = 1;

    
        
    #endregion
    private void Start()
    {
        #region �ƾǹB���
        print("�[�k:" + (numberA + numberB));
        print("��k:" + (numberA - numberB));
        print("���k:" + (numberA * numberB));
        print("���k:" + (numberA / numberB));
        print("�l��:" + (numberA % numberB));

        numberC = numberC - 1;
        print("numberC �� 1 " + numberC);
        numberC--;                        //����
        print("numberC �� 1 " + numberC);

        numberD = numberD + 10;
        print("numberD �[ 10 : " + numberD);
        numberD += 10;                    //���W���w + - * / %
        print("numberD �[10 : " + numberD);
        #endregion
        #region ����B���
        // �@�� : ����j�p�ȡA�åB�o���L�ȵ��G
        print("E > F :" + (numberE > numberF));  // t
        print("E < F :" + (numberE < numberF));  // f
        print("E >= F :" + (numberE >= numberF)); // t
        print("E <= F :" + (numberE <= numberF)); // f
        print("E == F :" + (numberE == numberF)); // f
        print("E != F :" + (numberE != numberF)); // t  
        #endregion

        #region �޿�B��l
        // �@��:�����ӥ��L�ȡA�åB�o���L�ȵ��G
        // �åB:�u�n���@�� false�A���G�� false
        print("T && T :" + (true && true));  // t
        print("F && T :" + (false && true)); // f
        print("T && F :" + (true && false)); // f
        print("F && F :" + (false && false)); // f
        // �Ϊ�:�u�n���@�� true�A���G�� true
        print("T || T :" + (true || true));  // t
        print("F || T :" + (false || true)); // t
        print("T || F :" + (true || false)); // t
        print("F || F :" + (false || false)); // f
        // �A�� !
        // �@��:�N���L�ȵ����ۤ�
        print("!true : " + (!true));         // f
        print("!false : " + (!false));       // t
        #endregion

    }
}

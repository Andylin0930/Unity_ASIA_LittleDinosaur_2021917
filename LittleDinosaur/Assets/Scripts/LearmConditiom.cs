
using UnityEngine;
/// <summary>
/// �{�ѧP�_�� (����)
/// </summary>
public class LearmConditiom : MonoBehaviour
{
    public bool OpenDoor;
    public int score = 70;
    public string weapon = "�M�l";

    //�}�l�ƥ� : ����C������@��
    private void Start()
    {
        #region �P�_�� if
        // �y�k :
        // ���L�Ȭ� true �|���� if �� {}
        // if ( ���L�� ) { �{�����e }
        if (true)
        {
            print("�{�ѧP�_�� if ");
        }
        // ���L�Ȭ� true �|���� if �� {}
        // ���L�Ȭ� false �|���� elsa �� {}
        // if ( ���L�� ) { �{�����e }
        // elsa { �{�����e }
        if (OpenDoor)
        {
            print("�}�� ! ");
        }
        else
        {
            print("���� ! ");
        }
        #endregion

    }
    //��s�ƥ� : ���@��60�� (60 FPS)
    private void Update()
    {
        print("�������~");

        #region �P�_�� if
        // �_�h �p�G elae if ( ���L�� ) { �{�����e } if �U�� elae �W�� �L�ƶq����
        // �p�G ���� >= 60 �ή�
        // �p�G ���� >= 60 ���O >= 40 �ɦ�
        // �_�h �N ���ή�
        if (score >= 60)
        {
            print("�ή�~");
        }
        else if (score >= 40)
        {
            print("�ɦ�~");
        }
        else
        {
            print("���ή�~");
        }
        #endregion

        #region
        // switch ( �� )
        // {
        //   case "�M�l":
        //      �����O 10 ;
        //      break; 
        //    case "�j�C":
        //      �����O 100 ;
        //    default:
        //       �o���O�Z��;
        //      break; 
        // }

        switch (weapon)
        {
            case "�M�l":
                print("�����O 10 ");
                break;
            case "�j�C":
                print("�����O 100 ");
                break;
            default:
                print("�o���O�Z��");
                break;
        }
        #endregion
    }
}

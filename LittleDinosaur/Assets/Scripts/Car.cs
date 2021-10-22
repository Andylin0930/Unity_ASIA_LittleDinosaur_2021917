using UnityEngine;   //�ޥ� Unity �����R�W�Ŷ�:�i�H�ϥΦ��Ŷ��� API

// ������
// Andy 2021 10 22 
// class ���O:�@�Ӫ����Ź�
// �y�k:���O ���O�W�� { ���O���e (���O����) }
// �����O�n�b Unity ���ϥΥ����~�� MonoBehaviour
public class Car : MonoBehaviour 
{
    #region ���y�k�Υ|�j�`������
    // ��� Filed : �O�s�U���������
    // �y�k : �׹��� ������� ���W�� ���w �w�]�� �����Ÿ�
    //  �|�j�`������
    // ��  ��:�x�s�S���p���I�����t��� - int
    // �B�I��:�x�s�a���p���I�����t��� - float
    // �r  ��:�x�s��r��T            - string
    // ���L��:�O�P�_ true�Bfalse      -bool
    // �׹���
    // �p�H:��L���O����s���B����� private (�w�]��)
    // �Ŷ}:��L���O�i�H�s���B��  �� publiv
    // ����ݩ� Attritube
    // �y�k: [�ݩʦW��(��)]
    // 1. ���D Header(�r��)
    // 2. ���� Tooltip(�r��) 
    // 3. �d�� Range(�̤j�ȡB�̤p��) - �ȾA�γ]������ int float
    [Header("CC��"), Range(1000, 3000)]
    public int cc = 1000;
    [Header("���q"), Range(1, 10)]
    public float weight = 3.5f;
    [Header("�~�P�W��")  ,Tooltip("���l�~�P")]
    public string brand = "���_��";
    [Header("�O�_���ѵ�")]
    public bool hasSkyWindows = true;
    #endregion

    #region �{�� Unity ���������
    // �C��B�V�q (�y��)�B����B�C������B����
    public Color color;
    public Color cololRed = Color.red;
    public Color cololRyellow = Color.yellow;
    public Color cololCustom1 = new Color(0, 0, 1);
    public Color cololCustom2 = new Color(1, 0, 1, 0.5f);
    // �V�q2 ~ 4 Vector
    public Vector2 v2;
    public Vector2 v2one = Vector2.one;
    public Vector2 v2Right = Vector2.right;
    public Vector2 v2left = Vector2.left;
    public Vector2 v2Custom = new Vector2(1, 2);
    public Vector3 v3Custom = new Vector3(1, 2, 3);
    // ���� keycode 
    public KeyCode keycode;
    public KeyCode keycodeMouseLeft = KeyCode.Mouse0;
    public KeyCode keycodeSpace = KeyCode.Space;
    // �C������ GameObject
    public GameObject goCamera;
    public GameObject goCar;
    // ���� Component 
    public Transform traCamera;
    public Camera cam;
    public SpriteRenderer apr;
    #endregion

    #region �ƥ� : �{���J�f
    // �}�l�ƥ� : �C������ɰ���@��
    private void Start()
    {
        // �I�s��k : ��k�W��();
        Test();
        Drive80();
        Drive100();
        Drive(120);    //�I�s�ɶ�J���٬�:�޼�
        float w99 = ConverWeight(9.9f);
        print("9.9 �ഫ : " + w99);

        print("���q�ഫ:" + ConverWeight(weight));
    }
    #endregion

    #region ��k�y�k
    // ��k : �O�s�{�����e���϶��B�t��k�B���z��
    // �y�k : �׹��� �Ǧ^���� ��k�W�� (�Ѽ�1�A�Ѽ�2 ... �Ѽ�N) { �{�����e }
    // void �L�Ǧ^ : �ϥΤ�k�ɤ��|���^�Ǹ��
    // �ۭq��k : ���|���� �����I�s�~�|���� 
    private void Test()
    {
        // ��X(�T��) - �N�T����X�� Unity ����O Console
        print("���o�A����");
    }

    private void Drive80()
    {
        print("�}���ɳt:" + 80);
        print("����:������");
        
    }

    private void Drive100()
    {
        print("�}���ɳt:" + 100);
        print("����:������");
    }

    // �Ѽƻy�k : ������� �ѼƦW��
    private void Drive(int speed)
    {
        print("�}���ɳt:" + speed);
        print("����:������");


    }

    private float ConverWeight(float setweight)
    {
        return setweight * 50; 
    }
    #endregion
}
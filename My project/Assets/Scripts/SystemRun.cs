using UnityEngine; // �ޥ� Unity  ���� �R�W�Ŷ� (API)
namespace Quentin
{
    //C# �q�Ź��ܦ����骫��
    //1. �����W���C������ Game Object �Ǧ�u�����
    //2. �N���}�����b�Ӫ����ܦ�����

/// <summary>
/// �]�B�t��
/// </summary>
public class SystemRun : MonoBehaviour
 {
        #region ��� : �O�s�t�λݭn�����

        //��� Field : �O�s���
        //�y�k :
        //�׹��� ��������� ���ۭq�W�� (���w �w�]��) ;

        //�׹���
        //���} : ��ܦb���O�A���\��L���O�s�� public
        //�p�H : ����ܦb���O�A�����\��L���O�s�� private (�ʸ�)

        //[] Attritube �ݩʡB�B�~�\��
        //Serialize Field �ǦC����� : �N�p�H������
        //Heder ���D : �i�H�ϥΤ���
        //Tooltip ���� : �i�H�ϥΤ���
        //Range �d�� : �ȭ���ƭ�������� int, float ,byte, long
        [SerializeField, Header("�]�B�t��"), Tooltip("���⪺�]�B�t��"), Range(0, 100)]
        private float speedRun = 3.5f; //�]�B�t��
        [SerializeField, Header("���D����"), Tooltip("���⪺���D����"), Range(0, 1000)]
        private float heightJump = 350; //���D����
        private Animator ani;   //�ʵe����
        private Rigidbody2D rig;    //���z�{�H
        #endregion

        #region �\�� : ��@�Өt�Ϊ�������k

        #endregion

        #region �ƥ� : �{���J�f
        //�}�l�ƥ� : ����C���ɰ���@��
        //��l�Ƴ]�w�B�Ҧp : �^���p�� 500 �������B�ͩR��l�� 3���R
        private void Start()
        {
            print("�C���}�l ^.^");
        }

        #endregion
    }
}


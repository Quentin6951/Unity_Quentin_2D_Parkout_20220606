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
       
        private Animator ani;   //�ʵe����
        private Rigidbody2D rig;    //���z�{�H
        #endregion

        #region �\�� : ��@�Өt�Ϊ�������k
         // ��k Method
         // �y�k
         //�׹��� �Ǧ^�������  ��k�W��(�Ѽ�) { �{�� }
         /// <summary>
         /// �]�B�\��
         /// </summary>

        private void Run()
        {
            print("�]�B��~");
            rig.velocity = new Vector2(speedRun, rig.velocity.y);
        }

        #endregion

        #region �ƥ� : �{���J�f
        //����ƥ� : �}�l�ƥ�e����@���A���o���󵥵�
        private void Awake()
        {
            //ani ���w �H�����W�� Animator
            ani = GetComponent<Animator>(); //����ʵe
            rig = GetComponent<Rigidbody2D>(); //�������(Rigidbody 2D)

        }



        //�}�l�ƥ� : ����C���ɰ���@��
        //��l�Ƴ]�w�B�Ҧp : �^���p�� 500 �������B�ͩR��l�� 3���R
        private void Start()
        {
           // print("�C���}�l ^.^");
        }

        //��s�ƥ� : �C���������Q�� 60FPS per second
        private void Update()
        {
            // print("<color=yellow>��s�ƥ���椤~</color>");


            //�I�s��k : ��k�W��(�������޼�)

            Run();
            
        }
        // ������Q�Ŀ�ɰ���@��
       private void OnEnable()
        {
            
        }
        // ������Q�����ɰ���@��
        private void OnDisable()
        {
            //�[�t���k�s
            rig.velocity = Vector3.zero;
        }
        #endregion
    }
}


using UnityEngine;

namespace Quentin
{
    /// <summary>
    /// API �R�A���ϥΤ覡
    /// </summary>
public class APIStatic : MonoBehaviour
{
        private void Start()
        {
            #region �ǲ�
            //���o�R�A�ݩ� get
            //�y�k :
            //���O . �R�A�ݩʦW�� �ƾ��ݩ� ;
            print("�H���� : " + Random.value); //�����H����
            print("PI : " + Mathf.PI); //���� PI��
            print("�L���j : " + Mathf.Infinity); //���� �L���j  ��

            //���o�R�A�ݩ� set (Read Only ����ϥ�)
            //�y�k :
            //���O . �R�A�ݩʦW��  ���w  ��;
            Cursor.visible = false;  //�ƹ�����
            Physics2D.gravity = new Vector2(0, -97.8f); //2���ɶ��V�q (����H���t��)
            Time.timeScale =0.9f; // ������骺�C���t��

            //���o�R�A��k
            //�y�k :
            //���O . �R�A��k�W��  (�����޼�);
           float range=Random.Range(20.5f, 100.5f);
            print("�H���d�� : " + range);
            #endregion

            #region �Ұ�ǲ�

            float �ƶq = Camera.allCameras.Length;
            print("�ڪ��Ҧ� " + �ƶq + " �۾�");

            if (Application.platform == RuntimePlatform.WindowsPlayer)
                Debug.Log("���ε{�������x");


            #endregion



        }

        private void Update()
        {
            #region �ǲ�
            int rangeInt = Random.Range(1, 3);
            print("�H����� 1 ~ 3 : " + rangeInt);
            #endregion

            #region �ǲ�


            #endregion



        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Quentin
{
    /// <summary>
    /// ���D�t��
    /// </summary>
    public class systemJump : MonoBehaviour
    {
        #region ���
        [SerializeField, Header("���D����"), Tooltip("���⪺���D����"), Range(0, 1000)]
        private float heightJump = 350; //���D����

        private Animator ani;   //�ʵe����
        private Rigidbody2D rig;    //���z�{�H
        private bool clickJump;
        #endregion

        #region �ƥ�
        private void Awake()
        {
            ani = GetComponent<Animator>();  //����ʵe
            rig = GetComponent<Rigidbody2D>(); //������� (Rigidbody 2D)
        }

        // Inpot API  ��ĳ�b  Update  �I�s
        // �@���  60 ��
        private void Update()
        {
            JumpKey();
        }

        // �@��T�w 50 ��
        private void FixedUpdate()
        {
            JumpForce();
        }
        #endregion

        #region �\��
        /// <summary>
        /// ���D����
        /// </summary>
        private void JumpKey()
        {
            // �p�G  ���a  ���U  �ť��� ���W�� ���D
            //if
            //switch
            //if �P�_���y�k : if (���L��) { ���L��  ��  true  ����{�� }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                print("���D~");
                clickJump = true;
            }
        }
        private void JumpForce()
        {
            if (clickJump)
            {
                rig.AddForce(new Vector2(0, heightJump));
                clickJump = false;
            }
        }
        #endregion
    }
}





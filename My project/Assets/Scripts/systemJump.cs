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
        [SerializeField, Header("�ˬd�a�O�ؤo")]
        private Vector3 v3CheckGroundSize = Vector3.one;
        [SerializeField, Header("�ˬd�a�O�첾")]
        private Vector3 v3CheckGroundoffset;
        [SerializeField, Header("�ˬd�a�O�C��")]
        private Color colorCheckGround = new Color(1,0,0.2f,0.5f);
        [SerializeField, Header("�ˬd�a�O�ϼh")]
        private LayerMask layerCheckGround;


        private Animator ani;   //�ʵe����
        private Rigidbody2D rig;    //���z�{�H
        private bool clickJump;
        private bool isGround;
        #endregion

        #region �ƥ�
        //ø�s�ϥ�
        //�b�s�边��ø�s���U�νu���B�Ϊ��ιϤ�
        private void OnDrawGizmos()
        {
            //1. �M�w�C��
            Gizmos.color = colorCheckGround;
            //2. ø�s�ϥ�
            Gizmos.DrawCube(transform.position + v3CheckGroundoffset , v3CheckGroundSize);

        }
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
            CheckGround();
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
               // print("���D~");
                clickJump = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space))
            {
                clickJump = false;
            }
        }
        private void JumpForce()
        {  // �p�G �I�����D �åB && �b�a�O�W
            if (clickJump && isGround)
            {
                rig.velocity = Vector3.zero;
                rig.AddForce(new Vector2(0, heightJump));
                clickJump = false;
            }
        }

        ///<summary>
        ///�ˬd�O�_�I��a�O
        ///</summary>
        private void CheckGround()
        {
            // 2D �I���� = 2D ���z.�л\���ΰϰ�(�����I�B�ؤo�B����);
            Collider2D hit = Physics2D.OverlapBox(transform.position + v3CheckGroundoffset, v3CheckGroundSize, 0, layerCheckGround);
            //print("�I�쪺���� :" + hit.name);
            isGround = hit;
        }
        #endregion
    }
}





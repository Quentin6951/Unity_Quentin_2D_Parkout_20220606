using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Quentin
{
    /// <summary>
    /// �D�R�A  API
    /// �P�R�A���t�O�b��ݭn�@�� (���骫��)
    /// (���骫��) �@�Ӧs�b������W�C������ Game Object
    /// </summary>


    public class APINonStaticrScript : MonoBehaviour
    {
        // 1. �w�q���A������������O
        // 2. Unity �ݩʭ��O�����T�w����줣�O None
        // 3. �ϥΫD�R�A API
        [SerializeField]
        private GameObject turtle;
        [SerializeField]
        private Transform startPoint;


        private void Start()
        {
            // �D�R�A�ݩ�
            // 1. ���o
            // �y�k : 
            // ���W��.�D�R�A�ݩ�
            print("�H�����⪺�Ұʪ��A : " + turtle.activeInHierarchy);
            print("�H������w�]�ϼh : " + turtle.layer);
            print("�_�I���y�� : " + startPoint.position);

            // 2. �]�w
            // �y�k : 
            // ���W��.�D�R�A�ݩ�  ���w  �� ;
            //turtle.activeInHierarchy = false; (���~�A��Ū�ݩ�  �x��S�g)
            turtle.tag = "Player";
            turtle.layer = 4;
            startPoint.position = new Vector3(-8, 5, 0);

            // 3. �ϥ� �D�R�A��k
            // �y�k : ���W��.�D�R�A��k(�������޼�);
            turtle.SetActive(false);
                     
           

        }
        private void Update()

        {
            startPoint.Translate(1.5f, 0, 0);
            startPoint.Rotate(0, 0,3.5f);
        }
             
    }
}
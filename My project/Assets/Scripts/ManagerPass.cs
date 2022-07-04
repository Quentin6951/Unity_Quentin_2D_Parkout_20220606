using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �޲z�L��
/// </summary>
namespace Quentin {


public class ManagerPass : MonoBehaviour
{
    [SerializeField, Header("�ؼЦW�l")]
    private string nameTarget = "����";
    [SerializeField, Header("�]�B�t��")]
    private SystemRun systemRun;
    [SerializeField, Header("���D�t��")]
    private systemJump systemJump;
    [SerializeField, Header("�����޲z��")]
    private ManagerFinal managerFinal;

        #region �䤤�@�Ӫ��󦳤Ŀ� IS Trigger
        //��Ӫ���I������@��
        private void OnTriggerEnter2D(Collider2D collision)
    {
       // print(collision.name);
       if(collision.name.Contains(nameTarget))
            {
                systemRun.enabled = false; //�����]�B�t��

                systemJump.enabled = false; //�������D�t��

                managerFinal.enabled = true; //�Ұʵ����޲z��

                managerFinal.strinTitle = "~�ש�]�������ȵ{~";

            }
    }
    //��Ӫ���I�����}����@��
    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }
    //��Ӫ���I�����|����@��
    private void OnTriggerStay2D(Collider2D collision)
    {
        
    }

    #endregion
}
}
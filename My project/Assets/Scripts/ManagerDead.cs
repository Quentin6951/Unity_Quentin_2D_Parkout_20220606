using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Quentin
{
    /// <summary>
    /// �޲z���`
    /// </summary>
   public class ManagerDead : MonoBehaviour
   {
        [SerializeField, Header("�ؼЦW�l")]
        private string nameTarget = "����";
        [SerializeField, Header("�����޲z��")]
        private ManagerFinal managerFinal;
        [SerializeField, Header("CM ��v�������")]
        private GameObject goCM;


        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.name.Contains(nameTarget))
            {
            
                managerFinal.strinTitle = "~���ߦ��F~";
                managerFinal.enabled = true; //�Ұʵ�����v��
                goCM.SetActive(false);
            }
        }
    }
    
}


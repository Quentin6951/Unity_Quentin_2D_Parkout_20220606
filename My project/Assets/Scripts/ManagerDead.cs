using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Quentin
{
    /// <summary>
    /// 管理死亡
    /// </summary>
   public class ManagerDead : MonoBehaviour
   {
        [SerializeField, Header("目標名子")]
        private string nameTarget = "鬼鬼";
        [SerializeField, Header("結束管理器")]
        private ManagerFinal managerFinal;
        [SerializeField, Header("CM 攝影機控制物件")]
        private GameObject goCM;


        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.name.Contains(nameTarget))
            {
            
                managerFinal.strinTitle = "~恭喜死了~";
                managerFinal.enabled = true; //啟動結束攝影機
                goCM.SetActive(false);
            }
        }
    }
    
}


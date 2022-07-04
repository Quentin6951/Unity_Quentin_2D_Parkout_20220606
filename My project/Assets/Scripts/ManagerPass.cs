using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 管理過關
/// </summary>
namespace Quentin {


public class ManagerPass : MonoBehaviour
{
    [SerializeField, Header("目標名子")]
    private string nameTarget = "鬼鬼";
    [SerializeField, Header("跑步系統")]
    private SystemRun systemRun;
    [SerializeField, Header("跳躍系統")]
    private systemJump systemJump;
    [SerializeField, Header("結束管理器")]
    private ManagerFinal managerFinal;

        #region 其中一個物件有勾選 IS Trigger
        //兩個物件碰撞執行一次
        private void OnTriggerEnter2D(Collider2D collision)
    {
       // print(collision.name);
       if(collision.name.Contains(nameTarget))
            {
                systemRun.enabled = false; //關閉跑步系統

                systemJump.enabled = false; //關閉跳躍系統

                managerFinal.enabled = true; //啟動結束管理器

                managerFinal.strinTitle = "~終於跑完遙遠旅程~";

            }
    }
    //兩個物件碰撞離開執行一次
    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }
    //兩個物件碰撞重疊執行一次
    private void OnTriggerStay2D(Collider2D collision)
    {
        
    }

    #endregion
}
}
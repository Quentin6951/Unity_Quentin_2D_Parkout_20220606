using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Quentin
{
    /// <summary>
    /// 跳躍系統
    /// </summary>
    public class systemJump : MonoBehaviour
    {
        #region 資料
        [SerializeField, Header("跳躍高度"), Tooltip("角色的跳躍高度"), Range(0, 1000)]
        private float heightJump = 350; //跳躍高度

        private Animator ani;   //動畫控制
        private Rigidbody2D rig;    //物理現象
        private bool clickJump;
        #endregion

        #region 事件
        private void Awake()
        {
            ani = GetComponent<Animator>();  //控制動畫
            rig = GetComponent<Rigidbody2D>(); //控制鋼體 (Rigidbody 2D)
        }

        // Inpot API  建議在  Update  呼叫
        // 一秒約  60 次
        private void Update()
        {
            JumpKey();
        }

        // 一秒固定 50 次
        private void FixedUpdate()
        {
            JumpForce();
        }
        #endregion

        #region 功能
        /// <summary>
        /// 跳躍按鍵
        /// </summary>
        private void JumpKey()
        {
            // 如果  玩家  按下  空白鍵 往上跳 跳躍
            //if
            //switch
            //if 判斷式語法 : if (布林值) { 布林值  為  true  執行程式 }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                print("跳躍~");
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





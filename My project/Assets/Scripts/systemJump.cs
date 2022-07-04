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
        [SerializeField, Header("檢查地板尺寸")]
        private Vector3 v3CheckGroundSize = Vector3.one;
        [SerializeField, Header("檢查地板位移")]
        private Vector3 v3CheckGroundoffset;
        [SerializeField, Header("檢查地板顏色")]
        private Color colorCheckGround = new Color(1,0,0.2f,0.5f);
        [SerializeField, Header("檢查地板圖層")]
        private LayerMask layerCheckGround;


        private Animator ani;   //動畫控制
        private Rigidbody2D rig;    //物理現象
        private bool clickJump;
        private bool isGround;
        #endregion

        #region 事件
        //繪製圖示
        //在編輯器內繪製輔助用線條、形狀或圖片
        private void OnDrawGizmos()
        {
            //1. 決定顏色
            Gizmos.color = colorCheckGround;
            //2. 繪製圖示
            Gizmos.DrawCube(transform.position + v3CheckGroundoffset , v3CheckGroundSize);

        }
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
            CheckGround();
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
               // print("跳躍~");
                clickJump = true;
            }
            else if (Input.GetKeyDown(KeyCode.Space))
            {
                clickJump = false;
            }
        }
        private void JumpForce()
        {  // 如果 點擊跳躍 並且 && 在地板上
            if (clickJump && isGround)
            {
                rig.velocity = Vector3.zero;
                rig.AddForce(new Vector2(0, heightJump));
                clickJump = false;
            }
        }

        ///<summary>
        ///檢查是否碰到地板
        ///</summary>
        private void CheckGround()
        {
            // 2D 碰撞器 = 2D 物理.覆蓋盒形區域(中心點、尺寸、角度);
            Collider2D hit = Physics2D.OverlapBox(transform.position + v3CheckGroundoffset, v3CheckGroundSize, 0, layerCheckGround);
            //print("碰到的物件 :" + hit.name);
            isGround = hit;
        }
        #endregion
    }
}





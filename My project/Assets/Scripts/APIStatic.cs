using UnityEngine;

namespace Quentin
{
    /// <summary>
    /// API 靜態的使用方式
    /// </summary>
public class APIStatic : MonoBehaviour
{
        private void Start()
        {
            #region 學習
            //取得靜態屬性 get
            //語法 :
            //類別 . 靜態屬性名稱 數學屬性 ;
            print("隨機值 : " + Random.value); //產生隨機值
            print("PI : " + Mathf.PI); //產生 PI值
            print("無限大 : " + Mathf.Infinity); //產生 無限大  值

            //取得靜態屬性 set (Read Only 不能使用)
            //語法 :
            //類別 . 靜態屬性名稱  指定  值;
            Cursor.visible = false;  //滑鼠隱藏
            Physics2D.gravity = new Vector2(0, -97.8f); //2維時間向量 (控制人物速度)
            Time.timeScale =0.9f; // 控制整體的遊戲速度

            //取得靜態方法
            //語法 :
            //類別 . 靜態方法名稱  (對應引數);
           float range=Random.Range(20.5f, 100.5f);
            print("隨機範圍 : " + range);
            #endregion

            #region 課堂學習

            float 數量 = Camera.allCameras.Length;
            print("我的所有 " + 數量 + " 相機");

            if (Application.platform == RuntimePlatform.WindowsPlayer)
                Debug.Log("應用程式的平台");


            #endregion



        }

        private void Update()
        {
            #region 學習
            int rangeInt = Random.Range(1, 3);
            print("隨機整數 1 ~ 3 : " + rangeInt);
            #endregion

            #region 學習


            #endregion



        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonStatic : MonoBehaviour
{
    [SerializeField] Camera 攝影機;
    [SerializeField] SphereCollider 碰撞器;
    [SerializeField] Transform 膠囊體, 立方體;
    [SerializeField] Rigidbody 加向上力;
    private void Start()
    {   //攝影機深度 (Depth)
        print(攝影機.depth);
        //體碰撞器半徑
        print(碰撞器.radius);
        //攝影機的背景顏色指定為隨機顏色
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        Color Color = new Color(r, g, b);
        攝影機.backgroundColor = Color;
        //膠囊體尺寸改為 3, 2, 1
        膠囊體.localScale = new Vector3(3, 2, 1);
    }

    private void Update()
    {
        //讓立方體看著球體旋轉
        立方體.RotateAround(立方體.gameObject.transform.position, Vector3.forward, 100 * Time.deltaTime);

        //讓膠囊體往上產生推力
        加向上力.AddForce(new Vector3(0, 4, 0));



    }
}





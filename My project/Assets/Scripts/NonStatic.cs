using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonStatic : MonoBehaviour
{
    [SerializeField] Camera ��v��;
    [SerializeField] SphereCollider �I����;
    [SerializeField] Transform ���n��, �ߤ���;
    [SerializeField] Rigidbody �[�V�W�O;
    private void Start()
    {   //��v���`�� (Depth)
        print(��v��.depth);
        //��I�����b�|
        print(�I����.radius);
        //��v�����I���C����w���H���C��
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        Color Color = new Color(r, g, b);
        ��v��.backgroundColor = Color;
        //���n��ؤo�אּ 3, 2, 1
        ���n��.localScale = new Vector3(3, 2, 1);
    }

    private void Update()
    {
        //���ߤ���ݵ۲y�����
        �ߤ���.RotateAround(�ߤ���.gameObject.transform.position, Vector3.forward, 100 * Time.deltaTime);

        //�����n�驹�W���ͱ��O
        �[�V�W�O.AddForce(new Vector3(0, 4, 0));



    }
}





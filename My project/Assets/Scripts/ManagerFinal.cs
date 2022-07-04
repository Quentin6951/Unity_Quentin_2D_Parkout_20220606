using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
namespace Quentin
{
    /// <summary>
    /// �޲z�����e��
    /// �L���P����
    /// </summary>
    public class ManagerFinal : MonoBehaviour
    {
        [SerializeField, Header("�e��")]
        private CanvasGroup groupFinal;
        [SerializeField, Header("�C���������D")]
        private TextMeshProUGUI textFinal;

        /// <summary>
        /// �C���������D����r���e
        /// </summary>
        public string strinTitle;

        private void Start()
        {
            textFinal.text = strinTitle;
            //MonoBehaviour ���O API �i�H�����ϥΦW�٩I�s
            InvokeRepeating("FadeIn", 0, 0.2f);
        }

        /// <summary>
        /// �H�J
        // </summary>
        private void FadeIn()
        {
            //�z���׻��W
            groupFinal.alpha += 0.1f;

            print("�H�J~");

            //�p�G �z���� >= 1 �N�Ұʤ��ʻP�B�׮g�u
            if (groupFinal.alpha >= 1)
            {
                groupFinal.interactable = true;
                groupFinal.blocksRaycasts = true;

                CancelInvoke("FadeIn");
            }

            //���s�P�{�����q�覡
            //1. �w�q���}�覡
        }    //2. Button on Click �]�w���}�������}��k
        public void Quit()
        {
            print("���}�C��");
            // �u�b�o�������� �q���P����˸m�W���@��
            Application.Quit();
        }
        /// <summary>
        /// ���s�C��
        /// </summary>
        public void Replay()
        {
            SceneManager.LoadScene("�C������");
        }

    }



    

}




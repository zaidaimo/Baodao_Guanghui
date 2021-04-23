using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class easy_Teach_isGame : MonoBehaviour
{
    public Transform[] SpawnPoints;  //�ͦ��@�Ӯy�Ъ��}�C
    public float spawnTime = 0.05f;  //1��ͦ��@����
    public GameObject[] Meats;
    public Player script;
    public static bool isGame;  //�O�_���b�i��C��

    public void Start()
    {
        isGame = true;
        if (isGame == true)
        {
            InvokeRepeating("CreateMeats", spawnTime, spawnTime);  //���ЩI�s (1��ͦ�,�C1��ͦ��@��)
        }
    }

    private void Update()
    {
        if (isGame == false)
        {
            CancelInvoke();
        }
    }
    public void StartDrop()
    {
        InvokeRepeating("CreateMeats", spawnTime, spawnTime);  //���ЩI�s (1��ͦ�,�C1��ͦ��@��)

    }

    void CreateMeats()  //�H����m �ͦ��Q�n������
    {
        if (isGame == true)
        {
            int spawnIndex = Random.Range(0, SpawnPoints.Length);  //�X�R�}�C�� �H���ͦ��d���ܻP �����I�ƶq �ۦP
            int meatIndex = Random.Range(0, Meats.Length);
            Instantiate(Meats[meatIndex], SpawnPoints[spawnIndex].position, SpawnPoints[spawnIndex].rotation);
        }

    }


}

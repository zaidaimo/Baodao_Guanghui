using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Finish_To_Tsai_Memory1 : MonoBehaviour
{
    Text showText;  //����Text�ե�
    string showStr;  //�]�m��r�T��

    public GameObject Next_Page;

    private void Start()
    {
        showText = GetComponent<Text>(); //�����Q�n����r
        showStr = "���G�p���A���ߩp�Ƿ|�F�o�D�Ʋz�I";  //�Q�n����r

        StartCoroutine(TypeText());  //�}��TypeText()

        Next_Page.SetActive(true);
    }

    private IEnumerator TypeText()
    {
        foreach (var item in showStr.ToCharArray())  //�ରchar������
        {
            showText.text += item;  //��ܤ�r
            yield return new WaitForSeconds(0.06f);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnType : MonoBehaviour
{
    public BTNType currentType;
    public void OnBtnClick()
    {
        switch (currentType)
        {
            case BTNType.New:
                Debug.Log("������");
                break;
            case BTNType.Continue:
                Debug.Log("�̾��ϱ�");
                break;
            case BTNType.Option:
                Debug.Log("�ɼ�");
                break;
            case BTNType.Sound:
                Debug.Log("����");
                break;
            case BTNType.back:
                Debug.Log("���ư���");
                break;
            case BTNType.Quit:
                Debug.Log("������");
                break;
        }
    }
}

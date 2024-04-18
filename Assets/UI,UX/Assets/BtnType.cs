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
                Debug.Log("새게임");
                break;
            case BTNType.Continue:
                Debug.Log("이어하기");
                break;
            case BTNType.Option:
                Debug.Log("옵션");
                break;
            case BTNType.Sound:
                Debug.Log("사운드");
                break;
            case BTNType.back:
                Debug.Log("돌아가기");
                break;
            case BTNType.Quit:
                Debug.Log("나가기");
                break;
        }
    }
}

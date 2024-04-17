using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossPattern : BossStatus
{
    public BoxCollider TestArea;
    public bool isAttack;
    private void FixedUpdate()
    {
        Target();
    }

    void Target()
    {
        
        if(!isAttack)
        {
            StartCoroutine(Think());
        }
        
    }
    
    IEnumerator Think()
    {
        yield return new WaitForSeconds(1f);

        int ranAction = Random.Range(0, 59);
        switch (ranAction)
        {
            case 0:
            case 1:
            case 2:
            case 3:
            case 4:        
            case 5:
            case 6:
            case 7:
            case 8:
            case 9:
                StartCoroutine(attack());
                break;
            case 10:
            case 11:
            case 12:
            case 13:
            case 14:
            case 15:
            case 16:
            case 17:
            case 18:
            case 19:
                StartCoroutine(PT1attack());
                break;
            case 20:
            case 21:
            case 22:
            case 23:
            case 24:
            case 25:
            case 26:
            case 27:
            case 28:
            case 29:
                StartCoroutine(EXattack());
                break;
            case 30:
            case 31:
            case 32:
            case 33:
            case 34:
            case 35:
            case 36:
            case 37:
            case 38:
            case 39:
                StartCoroutine(PT2attack());
                break;
            case 40:
            case 41:
            case 42:
            case 43:
            case 44:
            case 45:
            case 46:
            case 47:
            case 48:
            case 49:
                StartCoroutine(PT3attack());
                break;
            case 50:
            case 51:
            case 52:
            case 53:
            case 54:
            case 55:
            case 56:
            case 57:
            case 58:
            case 59:
                StartCoroutine(PT4attack());
                break;

            //코루틴 으로 작동
        }
    }
    IEnumerator attack()
    {
        Debug.Log("일반 공격");
        isAttack = true;
        yield return new WaitForSeconds(2.5f);
        TestArea.enabled = true;
        yield return new WaitForSeconds(0.1f);
        TestArea.enabled = false;

        isAttack = false;
        yield return new WaitForSeconds(2.1f);
        StartCoroutine(Think());
    }
    IEnumerator EXattack()
    {
        Debug.Log("특수 공격");
        isAttack = true;
        yield return new WaitForSeconds(2.5f);
        TestArea.enabled = true;
        yield return new WaitForSeconds(0.12f);
        TestArea.enabled = false;
        
        isAttack = false;
        yield return new WaitForSeconds(2.1f);
        StartCoroutine(Think());
    }
    IEnumerator PT1attack()
    {
        Debug.Log("패턴 공격1");
        isAttack = true;
        yield return new WaitForSeconds(2.5f);
        TestArea.enabled = true;
        yield return new WaitForSeconds(0.1f);
        TestArea.enabled = false;
        

        isAttack = false;
        yield return new WaitForSeconds(2.1f);
        StartCoroutine(Think());
    }
    IEnumerator PT2attack()
    {
        Debug.Log("패턴 공격2");
        isAttack = true;
        yield return new WaitForSeconds(2.5f);
        TestArea.enabled = true;
        yield return new WaitForSeconds(0.1f);
        TestArea.enabled = false;
       

        isAttack = false;
        yield return new WaitForSeconds(2.1f);
        StartCoroutine(Think());
    }
    IEnumerator PT3attack()
    {
        Debug.Log("패턴 공격3");
        isAttack = true;
        yield return new WaitForSeconds(2.5f);
        TestArea.enabled = true;
        yield return new WaitForSeconds(0.1f);
        TestArea.enabled = false;
        isAttack = false;
        yield return new WaitForSeconds(2.1f);
        StartCoroutine(Think());
    }
    IEnumerator PT4attack()
    {
        Debug.Log("패턴 공격4");
        isAttack = true;
        yield return new WaitForSeconds(0.1f);
        TestArea.enabled = true;
        yield return new WaitForSeconds(0.1f);
        TestArea.enabled = false;
        isAttack = false;
        yield return new WaitForSeconds(2.1f);
        StartCoroutine(Think());
    }
}

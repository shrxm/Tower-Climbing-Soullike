using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossStatus : MonoBehaviour
{
    public int maxHealth;
    public int curHealth;
    

    Rigidbody rigid;
    CapsuleCollider capsuleCollider;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        capsuleCollider = GetComponent<CapsuleCollider>();

    }
    
}

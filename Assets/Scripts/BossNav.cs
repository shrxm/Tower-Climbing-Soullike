using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BossNav : MonoBehaviour
{

    public Transform Target;

    NavMeshAgent nav;
    // Start is called before the first frame update
    private void Awake()
    {
        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        nav.SetDestination(Target.position);
    }
}

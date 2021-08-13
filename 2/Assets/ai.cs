using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ai : MonoBehaviour
{	private NavMeshAgent NashAgent;
	public Transform target;
    // Start is called before the first frame update
    void Start()
    {
         NashAgent=GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        NashAgent.SetDestination(target.position);
    }
}

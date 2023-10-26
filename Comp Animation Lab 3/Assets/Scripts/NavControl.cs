using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavControl : MonoBehaviour
{
    public GameObject target1;
    public GameObject target2;
    private bool isWalking = true;
    protected Animator animtor;
    public NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        animtor = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Random.Range(0, 2) == 1)
        {
            agent.destination = target1.transform.position;
        }
        else
        {
            agent.destination = target2.transform.position;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Contains("Attack"))
        {
            isWalking = false;
            animtor.SetTrigger("ATTACK");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Dragon")
        {
            isWalking = true;
            animtor.SetTrigger("WALK");
        }
    }
}

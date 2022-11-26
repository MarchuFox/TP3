using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Robot : MonoBehaviour
{
    public Animator RobotAnimator;
    public NavMeshAgent agent;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        RobotAnimator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player");
        InvokeRepeating("SearchPlayer", 3f,1f);

       // InvokeRepeating("RobotTelling",2f, 5f);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RobotTelling();
        }    
    }

    public void RobotTelling()
    {
        RobotAnimator.SetTrigger("DoTelling");
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("BULLET HIT");
            RobotAnimator.SetTrigger("DoDeath");
        }
    }
    public void SearchPlayer()
    {
        agent.SetDestination(player.transform.position);
    }
}

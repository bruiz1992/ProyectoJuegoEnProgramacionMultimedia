using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class IAEnemigo : MonoBehaviour
{
    public NavMeshAgent agent;

    public Transform player;

    public LayerMask queEsSuelo, queEsJugador;

    public float rangoVision, rangoAtaque;
    public bool playerIsInRange, playerIsInAttackRange;

    private void Awake()
    {
        player = GameObject.Find("Player").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        playerIsInRange = Physics.CheckSphere(transform.position, rangoVision, queEsJugador);
        playerIsInAttackRange = Physics.CheckSphere(transform.position, rangoAtaque, queEsJugador);

        if(playerIsInRange && !playerIsInAttackRange) ChasePlayer();

    }

    private void ChasePlayer()
    {
        agent.SetDestination(player.position);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, rangoAtaque);
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, rangoVision);
    }
}

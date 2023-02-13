using UnityEngine;
using UnityEngine.AI;

public class GuideNavigation : MonoBehaviour
{
    [SerializeField] NavMeshAgent agent;
    [SerializeField] float maxDistanceToPlayer = 5f;
    [SerializeField] float defaultAgentSpeed = 5f;
    [SerializeField] Transform targetPosition;
    public GameObject player;
    private float distanceAgentPlayer;
    private float playerSpeed;
      
    private void Start()
    {
        agent.speed = defaultAgentSpeed;
        agent.SetDestination(targetPosition.position);
    }
    private void Update()
    {
        distanceAgentPlayer = CalculateDistance(agent.transform, player.transform);
        if (distanceAgentPlayer > maxDistanceToPlayer)
        {
            agent.speed = 0;
        }
        else agent.speed = defaultAgentSpeed;
    }
    private float CalculateDistance(Transform a, Transform b)
    {
        return Vector3.Distance(a.position, b.position);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class MonsterController : MonoBehaviour
{
    private NavMeshAgent navAgent;
    public MonsterData data;

    private void Start()
    {
        if (navAgent == null)
            navAgent = this.GetComponent<NavMeshAgent>();

        if (data != null)
            LoadEnemy(data);
    }

    private void LoadEnemy(MonsterData _data)
    {
        foreach (Transform child in this.transform)
        {
            if (Application.isEditor)
                DestroyImmediate(child.gameObject);
            else
                Destroy(child.gameObject);
        }

        GameObject visuals = Instantiate(data.monsterModel);
        visuals.transform.SetParent(this.transform);
        visuals.transform.localPosition = Vector3.zero;
        visuals.transform.rotation = Quaternion.identity;

        if (navAgent == null)
            navAgent = this.GetComponent<NavMeshAgent>();

        this.navAgent.speed = data.Speed;
    }

    private void Update()
    {
        if (data == null)
            return;

        if (navAgent.remainingDistance < 1f)
            GetNewDestination();
    }

    private void GetNewDestination()
    {
        Vector3 nextDestination = this.transform.position;
        nextDestination += data.WanderDistance * new Vector3(Random.Range(-1f, 1f), 0f, Random.Range(-1f, 1f)).normalized;

        NavMeshHit hit;
        if (NavMesh.SamplePosition(nextDestination, out hit, 3f, NavMesh.AllAreas))
            navAgent.SetDestination(hit.position);
    }
}

using System;
using UnityEngine;

[CreateAssetMenu(fileName = "MonsterData", menuName = "Scriptable/Monster Data")]
public class MonsterData : UnitDataBase
{
    [SerializeField] private MonsterStats _monsterStats;
    public float WanderDistance { get { return _monsterStats.wanderDistance; } }

    public GameObject monsterModel;

    public string description;
}

[Serializable]
public struct MonsterStats
{
    public float experience;
    public float detectRange;
    public float aggressionRange;
    public float wanderDistance;
}
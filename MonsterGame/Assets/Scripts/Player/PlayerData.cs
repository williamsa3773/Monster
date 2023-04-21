using System;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Scriptable/Player Data")]
public class PlayerData : UnitDataBase
{
    [SerializeField] private PlayerStats _playerStats;

    public GameObject tierOneMonster;
    public GameObject tierTwoMonster;
    public GameObject tierThreeMonster;
}

[Serializable]
public struct PlayerStats
{
    public int level;
    public float experience;
}

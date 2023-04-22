using System;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Scriptable/Player Data")]
public class PlayerData : UnitDataBase
{
    [SerializeField] private PlayerStats _playerStats;
    public GameObject tierOneUnit;
    public GameObject tierTwoUnit;
    public GameObject tierThreeUnit;
    public Tier tier;
    public string description;
}

[Serializable]
public struct PlayerStats
{
    public int level;
    public float experience;
    
}

[Serializable]
public enum Tier
{
    tierOne = 1,
    tierTwo = 2,
    tierThree = 3,
}

using System;
using UnityEngine;

public abstract class UnitDataBase : ScriptableObject
{
    public string unitName;
    [SerializeField] private UnitStats _unitStats;
    public float Speed { get { return _unitStats.speed; } }
    public string description;
}

[Serializable]
public struct UnitStats
{
    public float health;
    public int attackPower;
    public float armorPower;
    public int skillPower;
    public float speed;
    public Species species;
}

public enum Species
{
    wolf = 0,
    bat = 1,
}

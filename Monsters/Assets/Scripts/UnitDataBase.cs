using System;
using UnityEngine;

public abstract class UnitDataBase : ScriptableObject
{
    [SerializeField] private Species species;
    [SerializeField] private MonsterType type;
}

public enum Species
{
    Mechanical = 0,
    Beast = 1,
    WingedBeast = 2,
}

public enum MonsterType
{
    Brute = 0,
    Balanced = 1,
    Speedster = 2,
    Caster = 3,
    Defender = 4,
}

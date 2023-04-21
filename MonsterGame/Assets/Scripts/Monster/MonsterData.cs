using System;
using UnityEngine;

[CreateAssetMenu(fileName = "MonsterData", menuName = "Scriptable/Monster Data")]
public abstract class MonsterData : ScriptableObject
{
    public string monsterName;
    [SerializeField] private Stats _stats;

    public GameObject monsterModel;
    public string description;
}


[Serializable]
public struct Stats
{
    public float health;
    public int attackPower;
    public float armorPower;
    public int skillPower;
    public float speed;
    public float detectRange;
    public float aggressionRange;
    public Species species;

}

[Serializable]
public enum Species
{
    wolf = 0,
    bat = 1,
}

using System;
using UnityEngine;

[CreateAssetMenu(fileName = "UnitScript", menuName = "Scriptable")]
public class UnitScript : UnitDataBase
{
    public GameObject unit;
    public string unitDescription;
    [SerializeField] UnitStats stats;
    [SerializeField] private MonsterTier tier;
    [SerializeField] private GameObject[] activeSkill1;
    [SerializeField] private GameObject[] activeSkill2;
    [SerializeField] private GameObject[] UltimateSkill1;
    [SerializeField] private GameObject[] passiveSkill1;
    [SerializeField] private GameObject[] passiveSkill2;
    
}

[Serializable]
public struct UnitStats
{
    public float health;
    public int attackPower;
    public int magicPower;
    public float armorValue;
    public float speed;
}

public enum MonsterTier
{
    TierOne = 1,
    TierTwo = 2,
    TierThree = 3,
}

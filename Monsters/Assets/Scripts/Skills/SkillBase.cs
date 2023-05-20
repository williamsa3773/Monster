using System;
using UnityEngine;

public abstract class SkillBase : ScriptableObject
{
    [SerializeField] private SkillDamageType damageType;
    [SerializeField] private SkillElement element;
    [SerializeField] private int SkillPower;
    [SerializeField] private string SkillDescription;
    [SerializeField] private float SkillCooldown;
    [SerializeField] private float SkillScaling;
}

public enum SkillDamageType
{
    Physical = 0,
    Magical = 1,
}

public enum SkillElement
{
    Neutral = 0,
    Ignis = 1,
    Torrent = 2,
    Zephyr = 3,
}




using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public interface IDamage
{
    void ReceiveDamage(float damage);
    bool indamageable { get; set; }

    bool isInShootable { get; set; }
}

public interface IHealth
{
    float maxHealth
    {
        get;
        set;
    }

    float currentHealth
    {
        get;
        set;
    }

    GameObject ownerHealth
    {
        get;
        set;
    }

    Type currentFunctionForAccess { get; set; }
    void RecoverHealth(float recoverHealth);
    object currentObject { get; set; }
    
}

public interface IDeath
{
    void DeathState();
}

using System;
using DesignPatterns.Stratagy_pattern;
using UnityEngine;

public class FireDamage : MonoBehaviour, IDoDamage
{
    [SerializeField] private float damageData;

    private void Awake()
    {
        Damage = damageData;
    }

    public float Damage { get; set; }
    public void DoDamage(float damage)
    {
        Debug.Log("Fire weapon attack");
    }
}

using DesignPatterns.Stratagy_pattern;
using UnityEngine;

public class IceDamage : MonoBehaviour, IDoDamage
{
    [SerializeField] private float damageData;

    private void Awake()
    {
        Damage = damageData;
    }

    public float Damage { get; set; }
    public void DoDamage(float damage)
    {
        Debug.Log("Ice weapon attack");
    }
}

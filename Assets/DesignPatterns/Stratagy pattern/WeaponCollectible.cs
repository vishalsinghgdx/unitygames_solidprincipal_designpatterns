using System;
using DesignPatterns.Stratagy_pattern;
using UnityEngine;

public class WeaponCollectible : MonoBehaviour
{
    [SerializeField] private PlayerWeaponController playerWeaponController;
    
    [SerializeField] private GameObject fireWeapon;
    [SerializeField] private GameObject swordWeapon;
    [SerializeField] private GameObject iceWeapon;

    private void Start()
    {
        playerWeaponController.SetWeapon(swordWeapon.GetComponent<IDoDamage>());
    }
}

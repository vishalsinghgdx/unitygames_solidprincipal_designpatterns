using DesignPatterns.Stratagy_pattern;
using UnityEngine;

namespace DesignPatterns.Stratagy_pattern
{
    public class PlayerWeaponController : MonoBehaviour
    {
        private IDoDamage _damage;

        public void SetWeapon(IDoDamage damage)
        {
            _damage = damage;
        }

        public void DoDamage()
        {
            _damage?.DoDamage(_damage.Damage);
        }
    }
}
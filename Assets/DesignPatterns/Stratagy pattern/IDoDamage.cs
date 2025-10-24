namespace DesignPatterns.Stratagy_pattern
{
    public interface IDoDamage
    {
        public float Damage { get; set; }
        void DoDamage(float damage);
    }
}
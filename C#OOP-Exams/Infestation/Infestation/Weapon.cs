namespace Infestation
{
    public class Weapon : EffectableSuplement
    {
        bool hasEffect = false;

        public Weapon()
            :base(10,0,3)
        {

        }
        
        public override void ReactTo(ISupplement otherSupplement)
        {
            if (otherSupplement is WeaponrySkill)
            {
                this.hasEffect = true;
            }
        }
    }
}

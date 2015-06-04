namespace Infestation
{
    public class EffectableSuplement : Supplement
    {
        protected bool hasEffect = false;

        public EffectableSuplement(int powerEffect, int healthEffect, int aggressionEffect)
            :base(powerEffect,healthEffect,aggressionEffect)
        {
        }
        public override int AggressionEffect
        {
            get
            {
                if (!this.hasEffect)
                {

                    return 0;
                }
                else
                {
                    return base.AggressionEffect;
                }
            }
            protected set
            {
                base.AggressionEffect = value;
            }
        }
        public override int HealthEffect
        {
            get
            {
                if (!this.hasEffect)
                {

                    return 0;
                }
                else
                {
                    return base.HealthEffect;
                }
            }
            protected set
            {
                base.HealthEffect = value;
            }

        }
        public override int PowerEffect
        {
            get
            {
                if (!this.hasEffect)
                {

                    return 0;
                }
                else
                {
                    return base.PowerEffect;
                }
            }
            protected set
            {
                base.PowerEffect = value;
            }

        }
    }
}

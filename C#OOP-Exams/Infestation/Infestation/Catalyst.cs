﻿namespace Infestation
{
    public abstract class Catalyst : Supplement , ISupplement
    {
        public Catalyst(int powerEffect,int healthEffect,int aggressionEffect)
            :base(powerEffect,healthEffect,aggressionEffect)
        {

        }
    }
}

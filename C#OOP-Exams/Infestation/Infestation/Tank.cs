﻿namespace Infestation
{
    using System;

    public class Tank : Unit
    {
        public Tank(string id)
            :base(id,UnitClassification.Mechanical,20,25,25)
        {

        }
    }
}

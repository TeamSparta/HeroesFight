﻿namespace HeroesFight.GameObjects.Heroes
{
    #region

    using System.Drawing;

    using HeroesFight.Interfaces;

    #endregion

    public abstract class Player : Hero, IPlayer
    {
        protected Player(Bitmap image, string name, int attackPoints, int healthPoints, int manaPoints, int shieldPower)
            : base(image, name, attackPoints, healthPoints, manaPoints, shieldPower)
        {
        }
    }
}
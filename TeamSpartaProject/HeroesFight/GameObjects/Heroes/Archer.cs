namespace HeroesFight.GameObjects.Heroes
{
    using System.Collections.Generic;
    using System.Drawing;

    using HeroesFight.Interfaces;
    using HeroesFight.Properties;

    public class Archer : Player
    {
        private const int StartingHealthPoints = 400;

        private const int StartingAttackPoints = 80;

        private const int StartingManaPoints = 180;

        private const int StartingShieldPower = 65;

        private static readonly Bitmap Image = Resources.Archer;

        private List<IMagic> magics = new List<IMagic>();

        public Archer(string name)
            : base(
                  Image,
                  name,
                  StartingAttackPoints,
                  StartingHealthPoints,
                  StartingManaPoints,
                  StartingShieldPower)
        {
        }
    }
}
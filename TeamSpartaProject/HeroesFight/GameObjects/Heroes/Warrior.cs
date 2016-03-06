namespace HeroesFight.GameObjects.Heroes
{
    #region

    using System.Collections.Generic;
    using System.Drawing;

    using HeroesFight.Interfaces;
    using HeroesFight.Properties;

    #endregion

    public class Warrior : Player
    {
        private const int StartingAttackPoints = 100;

        private const int StartingHealthPoints = 500;

        private const int StartingManaPoints = 150;

        private const int StartingShieldPower = 80;

        private static readonly Bitmap Image = Resources.Warrior;

        private IList<IMagic> magics = new List<IMagic>();

        public Warrior(string name)
            : base(Image, name, StartingAttackPoints, StartingHealthPoints, StartingManaPoints, StartingShieldPower)
        {
        }
    }
}
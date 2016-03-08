namespace HeroesFight.GameObjects.Heroes
{
    #region

    using System.Drawing;

    using HeroesFight.Enum;
    using HeroesFight.Properties;

    #endregion

    public class Archer : Player
    {
        private const HeroClass ArcherClass = HeroClass.Archer;

        private const int StartingAttackPoints = 80;

        private const int StartingHealthPoints = 400;

        private const int StartingManaPoints = 180;

        private const int StartingShieldPower = 65;

        private static readonly Bitmap Image = Resources.Archer;

        public Archer(string name)
            : base(
                Image, 
                name, 
                StartingAttackPoints, 
                StartingHealthPoints, 
                StartingManaPoints, 
                StartingShieldPower, 
                ArcherClass)
        {
        }
    }
}
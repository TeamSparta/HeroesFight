namespace HeroesFight.GameObjects.Heroes
{
    #region

    using System.Drawing;

    using HeroesFight.Enum;
    using HeroesFight.Properties;

    #endregion

    public class Warrior : Player
    {
        private const int StartingAttackPoints = 100;

        private const int StartingHealthPoints = 500;

        private const int StartingManaPoints = 150;

        private const int StartingShieldPower = 80;

        private const HeroClass WarriorClass = HeroClass.Warrior;

        private static readonly Bitmap Image = Resources.Warrior;

        public Warrior(string name)
            : base(
                Image, 
                name, 
                StartingAttackPoints, 
                StartingHealthPoints, 
                StartingManaPoints, 
                StartingShieldPower, 
                WarriorClass)
        {
        }
    }
}
namespace HeroesFight.GameObjects.Heroes
{
    using System.Drawing;

    using HeroesFight.Utilities;

    public class Archer : Player
    {
        private const int StartingHealthPoints = 400;

        private const int StartingAttackPoints = 80;

        private const int StartingManaPoints = 180;

        private const int StartingShieldPower = 65;

        private static readonly Image Image = Image.FromFile(Constants.ArcherImagePath);

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
namespace HeroesFight.GameObjects.Heroes
{
    using System.Drawing;

    public class Archer : Player
    {
        private const int StartingHealthPoints = 400;

        private const int StartingAttackPoints = 80;

        private const int StartingManaPoints = 180;

        private const int StartingShiledPower = 65;

        // trqbva da se sloji image
        private static Image image;

        public Archer()
            : base(image, StartingAttackPoints, StartingHealthPoints, StartingManaPoints, StartingShiledPower)
        {
        }
    }
}
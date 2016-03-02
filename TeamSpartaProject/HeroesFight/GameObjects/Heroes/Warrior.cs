namespace HeroesFight.GameObjects.Heroes
{
    using System.Collections.Generic;
    using System.Drawing;

    using global::HeroesFight.Interfaces;

    public class Warrior : Player
    {
        private const int StartingHealthPoints = 500;

        private const int StartingAttackPoints = 100;

        private const int StartingManaPoints = 150;

        private const int StartingShiledPower = 80;

        // TODO: trqbva da se sloji image
        private static readonly Image image = null;

        private List<IMagic> magics = new List<IMagic>();

        public Warrior()
            : base(image, StartingAttackPoints, StartingHealthPoints, StartingManaPoints, StartingShiledPower)
        {
        }
    }
}
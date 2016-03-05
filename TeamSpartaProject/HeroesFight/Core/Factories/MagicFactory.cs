namespace HeroesFight.Core.Factories
{
    using System.Drawing;

    using HeroesFight.Enum;
    using HeroesFight.GameObjects;
    using HeroesFight.Interfaces;
    using HeroesFight.Properties;
    using HeroesFight.Utilities;

    public class MagicFactory : IMagicFactory
    {
        public IMagic CreateMagic(string magicName)
        {
            IMagic magic;
            switch (magicName)
            {
                // Warrior spells
                case "FistAttack":
                    magic = new Magic(Resources.FistMagicIcon, magicName, 80, 0, 0, StateEnum.FirstLevelRoundOneState, ClassHeroEnum.Warrior);
                    break;
                case "SwordAttack":
                    magic = new Magic(Resources.SwordAttackMagicIcon, magicName, 100, 10, 0, StateEnum.FirstLevelRoundOneState, ClassHeroEnum.Warrior);
                    break;
                case "PoisonStrike":
                    magic = new Magic(Resources.PoisonStrikeMagicIcon, magicName, 110, 15, 5, StateEnum.FirstLevelRoundTwoState, ClassHeroEnum.Warrior);
                    break;
                case "LightningStrike":
                    magic = new Magic(Resources.LightSwordMagicIcon, magicName, 140, 20, 0, StateEnum.FirstLevelRoundThreeState, ClassHeroEnum.Warrior);
                    break;

                // Archer spells
                case "CounterShot":
                    magic = new Magic(Resources.CounterStrickeMagicIcon, magicName, 100, 10, 0, StateEnum.FirstLevelRoundOneState, ClassHeroEnum.Archer);
                    break;
                case "ThreeShot":
                    magic = new Magic(Resources.ThreeShotMagicIcon, magicName, 120, 20, 0, StateEnum.FirstLevelRoundOneState, ClassHeroEnum.Archer);
                    break;
                case "CritShot":
                    magic = new Magic(Resources.AirbowCritMagicIcon, magicName, 160, 35, 5, StateEnum.FirstLevelRoundTwoState, ClassHeroEnum.Archer);
                    break;
                case "MortalShot":
                    magic = new Magic(Resources.MortalMagicIcon, magicName, 180, 40, 0, StateEnum.FirstLevelRoundThreeState, ClassHeroEnum.Archer);
                    break;
                
                // UnholyWarrior spells
                case "SwordThrow":
                    magic = new Magic(default(Bitmap), magicName, 70, 10, 0, StateEnum.FirstLevelRoundOneState, ClassHeroEnum.Enemy);
                    break;
                case "FuriousRush":
                    magic = new Magic(default(Bitmap), magicName, 120, 30, 0, StateEnum.FirstLevelRoundOneState, ClassHeroEnum.Enemy);
                    break;

                // FireArcher spells
                case "FireArrow":
                    magic = new Magic(default(Bitmap), magicName, 70, 10, 0, StateEnum.FirstLevelRoundTwoState, ClassHeroEnum.Enemy);
                    break;
                case "Bomb":
                    magic = new Magic(default(Bitmap), magicName, 120, 30, 0, StateEnum.FirstLevelRoundTwoState, ClassHeroEnum.Enemy);
                    break;
                case "SteadyShot":
                    magic = new Magic(default(Bitmap), magicName, 120, 30, 0, StateEnum.FirstLevelRoundTwoState, ClassHeroEnum.Enemy);
                    break;

                // BloodlineMagician spells
                case "BloodDrain":
                    magic = new Magic(default(Bitmap), magicName, 120, 30, 0, StateEnum.FirstLevelRoundThreeState, ClassHeroEnum.Enemy);
                    break;
                case "BloodPool":
                    magic = new Magic(default(Bitmap), magicName, 150, 45, 0, StateEnum.FirstLevelRoundThreeState, ClassHeroEnum.Enemy);
                    break;
                case "MagicArc":
                    magic = new Magic(default(Bitmap), magicName, 160, 80, 0, StateEnum.FirstLevelRoundThreeState, ClassHeroEnum.Enemy);
                    break;
                case "BloodFire":
                    magic = new Magic(default(Bitmap), magicName, 200, 120, 0, StateEnum.FirstLevelRoundThreeState, ClassHeroEnum.Enemy);
                    break;

                default:
                    throw new MagicNotFoundException(magicName);
            }

            return magic;
        }
    }
}

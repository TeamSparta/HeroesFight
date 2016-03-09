namespace HeroesFight.Core.Factories
{
    #region

    using System.Drawing;

    using HeroesFight.Enums;
    using HeroesFight.GameObjects;
    using HeroesFight.Interfaces;
    using HeroesFight.Properties;
    using HeroesFight.Utilities;

    #endregion

    public class MagicFactory : IMagicFactory
    {
        public IMagic CreateMagic(string magicName)
        {
            IMagic magic;
            switch (magicName)
            {
                // Warrior spells
                case "FistAttack":
                    magic = new Magic(
                        Resources.FistMagicIcon, 
                        magicName, 
                        140, 
                        0, 
                        0, 
                        StateEnum.FirstLevelRoundOneState, 
                        HeroClass.Warrior);
                    break;
                case "SwordAttack":
                    magic = new Magic(
                        Resources.SwordAttackMagicIcon, 
                        magicName, 
                        100, 
                        10, 
                        0, 
                        StateEnum.FirstLevelRoundOneState, 
                        HeroClass.Warrior);
                    break;
                case "PoisonStrike":
                    magic = new Magic(
                        Resources.PoisonStrikeMagicIcon, 
                        magicName, 
                        110, 
                        15, 
                        5, 
                        StateEnum.FirstLevelRoundTwoState, 
                        HeroClass.Warrior);
                    break;
                case "LightningStrike":
                    magic = new Magic(
                        Resources.LightSwordMagicIcon, 
                        magicName, 
                        200, 
                        20, 
                        0, 
                        StateEnum.FirstLevelRoundThreeState, 
                        HeroClass.Warrior);
                    break;

                // Archer spells
                case "CounterShot":
                    magic = new Magic(
                        Resources.CounterStrickeMagicIcon, 
                        magicName, 
                        100, 
                        10, 
                        0, 
                        StateEnum.FirstLevelRoundOneState, 
                        HeroClass.Archer);
                    break;
                case "ThreeShot":
                    magic = new Magic(
                        Resources.ThreeShotMagicIcon, 
                        magicName, 
                        200, 
                        20, 
                        0, 
                        StateEnum.FirstLevelRoundOneState, 
                        HeroClass.Archer);
                    break;
                case "CritShot":
                    magic = new Magic(
                        Resources.AirbowCritMagicIcon, 
                        magicName, 
                        160, 
                        35, 
                        5, 
                        StateEnum.FirstLevelRoundTwoState, 
                        HeroClass.Archer);
                    break;
                case "MortalShot":
                    magic = new Magic(
                        Resources.MortalMagicIcon, 
                        magicName, 
                        180, 
                        40, 
                        0, 
                        StateEnum.FirstLevelRoundThreeState, 
                        HeroClass.Archer);
                    break;

                // UnholyWarrior spells
                case "SwordThrow":
                    magic = new Magic(
                        default(Bitmap), 
                        magicName, 
                        90, 
                        0, 
                        0, 
                        StateEnum.FirstLevelRoundOneState, 
                        HeroClass.Enemy);
                    break;
                case "FuriousRush":
                    magic = new Magic(
                        default(Bitmap), 
                        magicName, 
                        120, 
                        10, 
                        0, 
                        StateEnum.FirstLevelRoundOneState, 
                        HeroClass.Enemy);
                    break;

                // FireArcher spells
                case "FireArrow":
                    magic = new Magic(
                        default(Bitmap), 
                        magicName, 
                        100, 
                        0, 
                        0, 
                        StateEnum.FirstLevelRoundTwoState, 
                        HeroClass.Enemy);
                    break;
                case "Bomb":
                    magic = new Magic(
                        default(Bitmap), 
                        magicName, 
                        120, 
                        20, 
                        0, 
                        StateEnum.FirstLevelRoundTwoState, 
                        HeroClass.Enemy);
                    break;
                case "SteadyShot":
                    magic = new Magic(
                        default(Bitmap), 
                        magicName, 
                        120, 
                        30, 
                        0, 
                        StateEnum.FirstLevelRoundTwoState, 
                        HeroClass.Enemy);
                    break;

                // BloodlineMagician spells
                case "BloodDrain":
                    magic = new Magic(
                        default(Bitmap), 
                        magicName, 
                        120, 
                        30, 
                        0, 
                        StateEnum.FirstLevelRoundThreeState, 
                        HeroClass.Enemy);
                    break;
                case "BloodPool":
                    magic = new Magic(
                        default(Bitmap), 
                        magicName, 
                        150, 
                        45, 
                        0, 
                        StateEnum.FirstLevelRoundThreeState, 
                        HeroClass.Enemy);
                    break;
                case "MagicArc":
                    magic = new Magic(
                        default(Bitmap), 
                        magicName, 
                        160, 
                        80, 
                        0, 
                        StateEnum.FirstLevelRoundThreeState, 
                        HeroClass.Enemy);
                    break;
                case "BloodFire":
                    magic = new Magic(
                        default(Bitmap), 
                        magicName, 
                        200, 
                        120, 
                        0, 
                        StateEnum.FirstLevelRoundThreeState, 
                        HeroClass.Enemy);
                    break;

                default:
                    throw new MagicNotFoundException(magicName);
            }

            return magic;
        }
    }
}
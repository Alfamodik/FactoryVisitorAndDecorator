using System;

namespace Decorator
{
    public class PlayerStats : IPlayerStats
    {
        public PlayerStats(int strength, int intelligence, int dexterity)
        {
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
        }

        public int Strength { get; private set; }

        public int Intelligence { get; private set; }

        public int Dexterity { get; private set; }

        public void AddStrength(int strength)
        {
            if (Strength < 0)
                throw new ArgumentOutOfRangeException("Value cannot be negative!");

            Strength += strength;
        }

        public void AddIntelligence(int intelligence)
        {
            if(intelligence < 0)
                throw new ArgumentOutOfRangeException("Value cannot be negative!");

            Intelligence += intelligence;
        }

        public void AddDexterity(int dexterity)
        {
            if(dexterity < 0)
                throw new ArgumentOutOfRangeException("Value cannot be negative!");

            Dexterity += dexterity;
        }
    }
}
namespace Decorator
{
    public class Human : IPlayerStats
    {
        private IPlayerStats _playerStats;

        public Human(IPlayerStats playerStats)
        {
            _playerStats = playerStats;

            _playerStats.AddIntelligence(5);
            _playerStats.AddStrength(5);
        }

        public int Strength => _playerStats.Strength;
        public int Intelligence => _playerStats.Intelligence;
        public int Dexterity => _playerStats.Dexterity;

        public void AddStrength(int strength) => _playerStats.AddStrength(strength);

        public void AddIntelligence(int intelligence) => _playerStats.AddIntelligence(intelligence * 2);

        public void AddDexterity(int dexterity) => _playerStats.AddDexterity(dexterity);
    }
}

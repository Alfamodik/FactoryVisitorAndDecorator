namespace Decorator
{
    public class Brisk : IPlayerStats
    {
        private IPlayerStats _playerStats;

        public Brisk(IPlayerStats playerStats)
        {
            _playerStats = playerStats;

            _playerStats.AddDexterity(20);
        }

        public int Strength => _playerStats.Strength;
        public int Intelligence => _playerStats.Intelligence;
        public int Dexterity => _playerStats.Dexterity;

        public void AddStrength(int strength) => _playerStats.AddStrength(strength);

        public void AddIntelligence(int intelligence) => _playerStats.AddIntelligence(intelligence);

        public void AddDexterity(int dexterity) => _playerStats.AddDexterity(dexterity + 1);
    }
}

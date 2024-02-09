namespace Decorator
{
    public class Barbarian : IPlayerStats
    {
        private IPlayerStats _playerStats;

        public Barbarian(IPlayerStats playerStats)
        {
            _playerStats = playerStats;

            _playerStats.AddStrength(10);
        }

        public int Strength => _playerStats.Strength;
        public int Intelligence => _playerStats.Intelligence;
        public int Dexterity => _playerStats.Dexterity;

        public void AddStrength(int strength) => _playerStats.AddStrength(strength * 2);

        public void AddIntelligence(int intelligence) => _playerStats.AddIntelligence(intelligence);

        public void AddDexterity(int dexterity) => _playerStats.AddDexterity(dexterity);
    }
}

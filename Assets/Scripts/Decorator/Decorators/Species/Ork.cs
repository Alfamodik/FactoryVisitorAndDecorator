namespace Decorator
{
    public class Ork : IPlayerStats
    {
        private IPlayerStats _playerStats;

        public Ork(IPlayerStats playerStats)
        {
            _playerStats = playerStats;

            _playerStats.AddDexterity(5);
            _playerStats.AddStrength(5);
        }

        public int Strength => _playerStats.Strength;
        public int Intelligence => _playerStats.Intelligence;
        public int Dexterity => _playerStats.Dexterity;

        public void AddStrength(int strength) => _playerStats.AddStrength(strength * 2);

        public void AddIntelligence(int intelligence) => _playerStats.AddIntelligence(intelligence);

        public void AddDexterity(int dexterity) => _playerStats.AddDexterity(dexterity);
    }
}

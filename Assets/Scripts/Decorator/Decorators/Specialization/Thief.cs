namespace Decorator
{
    public class Thief : IPlayerStats
    {
        private IPlayerStats _playerStats;

        public Thief(IPlayerStats playerStats)
        {
            _playerStats = playerStats;

            _playerStats.AddDexterity(10);
        }

        public int Strength => _playerStats.Strength;
        public int Intelligence => _playerStats.Intelligence;
        public int Dexterity => _playerStats.Dexterity;

        public void AddStrength(int strength) => _playerStats.AddStrength(strength);

        public void AddIntelligence(int intelligence) => _playerStats.AddIntelligence(intelligence);

        public void AddDexterity(int dexterity) => _playerStats.AddDexterity(dexterity * 2);
    }
}

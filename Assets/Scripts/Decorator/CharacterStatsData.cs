using UnityEngine;

namespace Decorator

{
    [CreateAssetMenu(fileName = "CharacterStatsData", menuName = "CharacterStatsData/CharacterStatsData")]
    public class CharacterStatsData : ScriptableObject
    {
        [SerializeField] private int _strength;
        [SerializeField] private int _intelligence;
        [SerializeField] private int _dexterity;

        public int Strength => _strength;

        public int Intelligence => _intelligence;

        public int Dexterity => _dexterity;
    }
}
using UnityEngine;

namespace Assets.Visitor
{
    [CreateAssetMenu(fileName = "SpawnData", menuName = "EnemyFactory/SpawnData")]
    public class SpawnerData : ScriptableObject
    {
        [SerializeField] private int _maxValue;
        [SerializeField] private int _elf;
        [SerializeField] private int _human;
        [SerializeField] private int _ork;
        [SerializeField] private int _robot;

        public int MaxValue => _maxValue;

        public int Elf => _elf;

        public int Human => _human;

        public int Ork => _ork;

        public int Robot => _robot;
    }
}
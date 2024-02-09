using UnityEngine;

[CreateAssetMenu(fileName = "MainMenuResources", menuName = "CoinFactory/MainMenuResources")]
public class MainMenuResources : ScriptableObject
{
    [SerializeField] private Energy _energy;
    [SerializeField] private Gem _gem;

    public Energy Energy => _energy;
    public Gem Gem => _gem;
}
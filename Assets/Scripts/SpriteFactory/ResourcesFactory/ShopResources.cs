using UnityEngine;

[CreateAssetMenu(fileName = "ShopResources", menuName = "CoinFactory/ShopResources")]
public class ShopResources : ScriptableObject
{
    [SerializeField] private Money _coin;
    [SerializeField] private Gem _gem;

    public Money Coin => _coin;
    public Gem Gem => _gem;
}

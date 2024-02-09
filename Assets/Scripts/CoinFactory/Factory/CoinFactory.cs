using UnityEngine;

public class CoinFactory
{
    private Coin _coinPrefab;

    public CoinFactory(Coin prefab) => _coinPrefab = prefab;

    public Coin Get() => MonoBehaviour.Instantiate(_coinPrefab);
}
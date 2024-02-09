using System;
using UnityEngine;

public class PlaceForCoin : MonoBehaviour
{
    private bool _isFree = true;
    private Coin _currentCoin;

    public bool IsFree => _isFree;

    public void Set(Coin coin)
    {
        if (_isFree == false)
            throw new Exception("This place is already occupied, use IsFree to check for availability");

        _currentCoin = coin;
        _currentCoin.PickedUp += ToFree;

        _currentCoin.Locate(transform);
        _isFree = false;
    }

    private void ToFree()
    {
        _isFree = true;
        _currentCoin.PickedUp -= ToFree;
    }
}

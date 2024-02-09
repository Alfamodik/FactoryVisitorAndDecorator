using System;
using UnityEngine;

public class ShopResourcesFactory : ResourcesFactory
{
    [SerializeField] private ShopResources _resourses;

    public ShopResourcesFactory(ShopResources resourses) => _resourses = resourses;

    public override IResources Get(ResoursesType type)
    {
        switch (type)
        {
            case ResoursesType.Coin:
            return _resourses.Coin;

            case ResoursesType.Energy:
            return _resourses.Gem;

            default:
            throw new ArgumentException();
        }
    }
}

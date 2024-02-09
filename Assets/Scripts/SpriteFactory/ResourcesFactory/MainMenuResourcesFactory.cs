using System;
using UnityEngine;

public class MainMenuResourcesFactory : ResourcesFactory
{
    private MainMenuResources _resourses;

    public MainMenuResourcesFactory(MainMenuResources resourses) => _resourses = resourses;

    public override IResources Get(ResoursesType type)
    {
        switch (type)
        {
            case ResoursesType.Gem:
            return _resourses.Gem;

            case ResoursesType.Energy:
            return _resourses.Energy;

            default:
            throw new ArgumentException();
        }
    }
}

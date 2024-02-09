using UnityEngine;

public abstract class ResourcesFactory
{
    public abstract IResources Get(ResoursesType type);
}

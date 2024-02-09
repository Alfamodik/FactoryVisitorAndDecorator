using UnityEngine;

public abstract class ILocateable : MonoBehaviour
{
    public void Locate(Transform transf)
    {
        transform.position = transf.position;
        transform.rotation = transf.rotation;
    }
}

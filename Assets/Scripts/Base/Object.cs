using UnityEngine;

public abstract class Object : MonoBehaviour, IInteractable
{
    public string objName;
    public abstract void Interact();

    protected virtual void Awake()
    {
        if (string.IsNullOrEmpty(objName))
            objName = gameObject.name;
    }
}

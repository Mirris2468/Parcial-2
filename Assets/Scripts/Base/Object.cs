using UnityEngine;
//Script de objetos donde se puede colocar un nombre personalizado para el objeto que utiliza este script
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

using UnityEngine;

public abstract class InteractableObjects : MonoBehaviour
{
    protected enum ObjType { SHOWER, KITCHEN, BOTTLES, RADIO};

    public abstract void DoMiniGame();
}

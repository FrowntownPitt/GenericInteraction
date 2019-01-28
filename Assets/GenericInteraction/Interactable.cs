using JetBrains.Annotations;
using UnityEngine;

namespace GenericInteraction
{
    public abstract class Interactable : MonoBehaviour
    {
        [UsedImplicitly]
        public abstract void Interact();
    }
}
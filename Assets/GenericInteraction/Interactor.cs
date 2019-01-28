using JetBrains.Annotations;
using UnityEngine;

namespace GenericInteraction
{
    public abstract class Interactor : MonoBehaviour
    {
        [UsedImplicitly] public string interactorName;

        public abstract bool IsInteracting();
    }
}
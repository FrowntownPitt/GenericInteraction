using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace GenericInteraction.Interactors
{
    public class MultiInputInteractor : Interactor
    {
        [SerializeField] private bool requiresAll;
        [SerializeField] private List<Interactor> interactors;

        public override bool IsInteracting()
        {
            return requiresAll ? interactors.All(c => c.IsInteracting()) : interactors.Any(c => c.IsInteracting());
        }
    }
}
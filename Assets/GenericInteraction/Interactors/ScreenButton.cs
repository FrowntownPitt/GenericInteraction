using System;
using UnityEngine;
using UnityEngine.UI;

namespace GenericInteraction.Interactors
{
    public class ScreenButton : Interactor
    {
        [SerializeField] private Button screenButton;

        public override bool IsInteracting()
        {
            throw new NotImplementedException();
        }
    }
}
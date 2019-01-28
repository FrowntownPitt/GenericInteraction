using UnityEngine;

namespace GenericInteraction.Interactors
{
    public class KeyboardButton : Interactor
    {
        [SerializeField] private string buttonName;

        public override bool IsInteracting()
        {
            return Input.GetButton(buttonName);
        }
    }
}
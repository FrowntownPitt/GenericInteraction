using UnityEngine;

namespace GenericInteraction.Interactors
{
    public class GamepadButton : Interactor
    {
        [SerializeField] private KeyCode buttonName;

        public override bool IsInteracting()
        {
            return Input.GetKey(buttonName);
        }
    }
}
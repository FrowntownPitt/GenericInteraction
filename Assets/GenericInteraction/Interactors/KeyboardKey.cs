using UnityEngine;

namespace GenericInteraction.Interactors
{
    public class KeyboardKey : Interactor
    {
        [SerializeField] private KeyCode keycode;

        public override bool IsInteracting()
        {
            return Input.GetKey(keycode);
        }
    }
}
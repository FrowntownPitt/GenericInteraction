using UnityEngine;

namespace GenericInteraction.Interactors
{
    public class GamepadJoystick : Interactor
    {
        [SerializeField] private string axisName;
        [SerializeField] private float joystickThreshold;
        [SerializeField] private bool joystickDirection;

        public override bool IsInteracting()
        {
            if (joystickDirection)
                return Input.GetAxisRaw(axisName) > joystickThreshold;

            return Input.GetAxisRaw(axisName) < joystickThreshold;
        }
    }
}
using UnityEngine;

namespace GenericInteraction.Interactables
{
    public class Hyperlink : Interactable
    {
        [SerializeField] private string link;

        public override void Interact()
        {
            Application.OpenURL(link);
        }
    }
}
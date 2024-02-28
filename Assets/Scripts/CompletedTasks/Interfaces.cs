using System.Collections.Generic;
using UnityEngine;
namespace MainPlayer.UnityEngine
{
    public interface IInteractable
    {
        Vector3 Position { get; }
        void Interact();
    }

    public class PlayerInteraction : MonoBehaviour
    {
        public float interactRange = 10f;
        [SerializeReference] // Added SerializeReference to make it easier to edit the list of objects in the Unity inspector.
        List<IInteractable> interactableObjects = new List<IInteractable>();

        void Start()
        {
           // Find all objects on the scene that implement the IInteractable interface, if [SerializeReference] is not used
            //MonoBehaviour[] allScripts = FindObjectsOfType<MonoBehaviour>();
            //for (int i = 0; i < allScripts.Length; i++)
            //{
            //   if(allScripts[i] is IInteractable)
            //        interactableObjects.Add(allScripts[i] as IInteractable);
            //}
        }

        // A method that is called when the player interacts with an object.
        public void InteractWithObjects()
        {
            foreach(IInteractable interactableObject in interactableObjects)
            {
                float distance = Vector3.Distance(interactableObject.Position, transform.position);
                if(distance < interactRange)
                    interactableObject.Interact();
            }
        }
    }

    public class Door : MonoBehaviour, IInteractable
    {
        public Vector3 Position
        {
            get { return transform.position; }
        }

        public void Interact()
        {
            Debug.Log("The door opens.");
        }
    }

    public class Button : MonoBehaviour, IInteractable
    {
        public Vector3 Position
        {
            get { return transform.position; }
        }

        public void Interact()
        {
            Debug.Log("The button is pressed.");
        }
    }

}
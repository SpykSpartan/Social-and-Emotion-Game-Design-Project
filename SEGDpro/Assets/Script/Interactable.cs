using UnityEngine;

public class Interactable : MonoBehaviour
{
    public string promptText = "Interact";

    public virtual void Interact() { }

    public virtual string GetPrompt()
    {
        return promptText;
    }
}
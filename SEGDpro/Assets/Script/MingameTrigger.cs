using UnityEngine;

public class MinigameTrigger : Interactable
{
    public GameObject minigameUI;

    void Start()
    {
        promptText = "Play Minigame";
    }

    public override void Interact()
    {
        minigameUI.SetActive(true);
    }
}
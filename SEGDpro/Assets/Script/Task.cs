using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskInteract : Interactable
{
    public Task task;

    public AudioClip completeSFX;
    private AudioSource audioSource;

    void Start()
    {
        promptText = "Complete " + task.taskName;
        audioSource = GetComponent<AudioSource>();
    }

    public override void Interact()
    {
        task.CompleteTask();

        if (completeSFX != null && audioSource != null)
        {
            audioSource.PlayOneShot(completeSFX);
        }
    }
}
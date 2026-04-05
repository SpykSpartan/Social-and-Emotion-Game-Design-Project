using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskInteract : Interactable
{
    public Task task;

    void Start()
    {
        promptText = "Complete " + task.taskName;
    }

    public override void Interact()
    {
        task.CompleteTask();
    }
}
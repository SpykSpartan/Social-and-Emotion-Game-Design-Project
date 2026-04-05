using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fidget : Interactable
{
    public float reliefAmount = 10f;

    void Start()
    {
        promptText = "Use Fidget";
    }

    public override void Interact()
    {
        StressManager.Instance.ReduceStress(reliefAmount);
    }
}


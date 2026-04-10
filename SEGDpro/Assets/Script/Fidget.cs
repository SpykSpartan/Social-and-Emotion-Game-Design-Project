using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fidget : Interactable
{
    public float reliefAmount = 10f;

    public AudioClip useSFX;
    private AudioSource audioSource;

    void Start()
    {
        promptText = "Use Fidget";
        audioSource = GetComponent<AudioSource>();
    }

    public override void Interact()
    {
        StressManager.Instance.ReduceStress(reliefAmount);

        if (useSFX != null && audioSource != null)
        {
            audioSource.PlayOneShot(useSFX);
        }
    }
}
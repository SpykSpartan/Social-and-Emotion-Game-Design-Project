using UnityEngine;

public class NPC : Interactable
{
    public float minStress = -10f;
    public float maxStress = 15f;

    public AudioClip talkSFX;
    private AudioSource audioSource;

    void Start()
    {
        promptText = "Talk";
        audioSource = GetComponent<AudioSource>();
    }

    public override void Interact()
    {
        float result = Random.Range(minStress, maxStress);
        StressManager.Instance.AddStress(result);

        if (talkSFX != null && audioSource != null)
        {
            audioSource.PlayOneShot(talkSFX);
        }
    }
}
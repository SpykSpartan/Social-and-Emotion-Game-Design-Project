using UnityEngine;

public class NPC : Interactable
{
    public float minStress = -10f;
    public float maxStress = 15f;

    void Start()
    {
        promptText = "Talk";
    }

    public override void Interact()
    {
        float result = Random.Range(minStress, maxStress);
        StressManager.Instance.AddStress(result);
    }
}
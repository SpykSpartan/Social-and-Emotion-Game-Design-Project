using UnityEngine;

public class StressManager : MonoBehaviour
{
    public static StressManager Instance;

    [Range(0, 100)]
    public float stress = 20f;

    public float passiveStressPerSecond = 1f;

    void Awake()
    {
        Instance = this;
    }

    void Update()
    {
        stress += passiveStressPerSecond * Time.deltaTime;
        stress = Mathf.Clamp(stress, 0, 100);
    }

    public void AddStress(float amount)
    {
        stress += amount;
        stress = Mathf.Clamp(stress, 0, 100);
    }

    public void ReduceStress(float amount)
    {
        stress -= amount;
        stress = Mathf.Clamp(stress, 0, 100);
    }
}
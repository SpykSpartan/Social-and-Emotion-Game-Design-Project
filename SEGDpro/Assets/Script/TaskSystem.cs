using UnityEngine;

public class Task : MonoBehaviour
{
    public string taskName;
    public float stressPerSecond = 2f;
    public bool isCompleted = false;

    void Start()
    {
        TaskUIManager.Instance.AddTask(this);
    }

    void Update()
    {
        if (!isCompleted)
        {
            StressManager.Instance.AddStress(stressPerSecond * Time.deltaTime);
        }
    }

    public void CompleteTask()
    {
        isCompleted = true;

        StressManager.Instance.ReduceStress(15f);

        TaskUIManager.Instance.RemoveTask(this);

        gameObject.SetActive(false);
    }
}
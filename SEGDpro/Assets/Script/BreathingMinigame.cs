using UnityEngine;

public class BreathingMinigame : MinigameBase
{
    public float cycleTime = 4f;
    public float gameDuration = 15f;

    private float timer;
    private int successCount;

    public RectTransform circle;

    void OnEnable()
    {
        timer = 0f;
        successCount = 0;
    }

    void Update()
    {
        timer += Time.unscaledDeltaTime;

        float t = Mathf.PingPong(timer, cycleTime) / cycleTime;

        float scale = Mathf.Lerp(0.5f, 1.5f, t);
        circle.localScale = Vector3.one * scale;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            float stress = StressManager.Instance.stress;

            float windowSize = Mathf.Lerp(0.2f, 0.05f, stress / 100f);

            if (Mathf.Abs(t - 1f) < windowSize)
            {
                successCount++;
                Debug.Log("Good timing!");
            }
            else
            {
                Debug.Log("Miss");
            }
        }

        if (timer >= gameDuration)
        {
            End();
        }
    }

    void End()
    {
        StressManager.Instance.ReduceStress(successCount * 5f);
        EndGame();
    }
}
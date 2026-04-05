using UnityEngine;

public class Minigame : MonoBehaviour
{
    public float duration = 3f;
    private float timer;
    private int presses;

    void Update()
    {
        timer += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            presses++;
        }

        if (timer >= duration)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        float relief = Mathf.Clamp(presses * 2f, 5f, 30f);
        StressManager.Instance.ReduceStress(relief);

        gameObject.SetActive(false);
    }
}
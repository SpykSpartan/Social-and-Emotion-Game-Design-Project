using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float gameDuration = 300f;
    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= gameDuration)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        float finalStress = StressManager.Instance.stress;

        if (finalStress < 30)
            Debug.Log("Calm ending");
        else if (finalStress < 70)
            Debug.Log("Managed ending");
        else
            Debug.Log("Overwhelmed ending");
    }
}
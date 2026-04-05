using UnityEngine;

public class CleanMinigame : MonoBehaviour
{
    public int itemsToClean = 5;
    private int cleaned = 0;

    public void CleanItem(GameObject obj)
    {
        obj.SetActive(false);
        cleaned++;

        if (cleaned >= itemsToClean)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        StressManager.Instance.ReduceStress(25f);
        gameObject.SetActive(false);
    }
}
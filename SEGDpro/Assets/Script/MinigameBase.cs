using UnityEngine;

public class MinigameBase : MonoBehaviour
{
    public virtual void StartGame()
    {
        gameObject.SetActive(true);
        Time.timeScale = 0f;
        PlayerMovement.canMove = false;
    }

    public virtual void EndGame()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1f;
        PlayerMovement.canMove = true;
    }
}
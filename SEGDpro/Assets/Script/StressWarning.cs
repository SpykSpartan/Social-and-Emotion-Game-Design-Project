using UnityEngine;
using TMPro;

public class StressWarning : MonoBehaviour
{
    public TextMeshProUGUI warningText;

    void Update()
    {
        float stress = StressManager.Instance.stress;

        if (stress > 70)
        {
            warningText.text = "Too much...";
        }
        else
        {
            warningText.text = "";
        }
    }
}
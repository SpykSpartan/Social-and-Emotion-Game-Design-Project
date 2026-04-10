using UnityEngine;
using UnityEngine.UI;

public class StressUI : MonoBehaviour
{
    public Slider slider;
    public Image fill;

    void Update()
    {
        float stress = StressManager.Instance.stress;
        slider.value = stress;

        fill.color = Color.Lerp(Color.green, Color.red, stress / 100f);
    }
}
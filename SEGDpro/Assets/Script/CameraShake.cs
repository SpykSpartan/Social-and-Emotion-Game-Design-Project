using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public float maxShake = 0.2f;

    private Vector3 originalPos;

    void Start()
    {
        originalPos = transform.localPosition;
    }

    void Update()
    {
        float stress = StressManager.Instance.stress;

        if (stress > 25f)
        {
            float t = Mathf.InverseLerp(25f, 75f, stress);

            float shakeAmount = t * maxShake;

            Vector3 randomOffset = Random.insideUnitSphere * shakeAmount;

            transform.localPosition = originalPos + randomOffset;
        }
        else
        {
            transform.localPosition = originalPos;
        }
    }
}
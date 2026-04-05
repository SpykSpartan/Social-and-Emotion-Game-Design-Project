using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class StresVisuals : MonoBehaviour
{
    public Volume volume;

    private DepthOfField dof;

    void Start()
    {
        volume.profile.TryGet(out dof);
    }

    void Update()
    {
        float stress = StressManager.Instance.stress;

        if (stress > 50f)
        {
            float t = Mathf.Clamp01((stress - 50f) / 50f);
            t = t * t;

            dof.active = true;
            dof.gaussianStart.value = Mathf.Lerp(0.05f, 3f, t);
            dof.gaussianEnd.value = Mathf.Lerp(0.5f, 8f, t);
        }
        else
        {
            dof.active = false;
        }
    }
}
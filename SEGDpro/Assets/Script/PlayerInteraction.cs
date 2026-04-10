using UnityEngine;
using TMPro;

public class PlayerInteraction : MonoBehaviour
{
    public float interactDistance = 3f;
    public LayerMask interactLayer;
    public Camera cam;

    public GameObject interactUI;
    public TextMeshProUGUI interactText;

    private Interactable currentTarget;

    void Update()
    {
        if (!PlayerMovement.canMove) return;

        CheckForInteractable();

        if (Input.GetKeyDown(KeyCode.E) && currentTarget != null)
        {
            currentTarget.Interact();
        }
    }
    void CheckForInteractable()
    {
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, interactDistance, interactLayer))
        {
            Interactable interactable = hit.collider.GetComponent<Interactable>();

            if (interactable != null)
            {
                currentTarget = interactable;
                interactUI.SetActive(true);

                interactText.text = "Press E to " + interactable.GetPrompt();
                return;
            }
        }

        currentTarget = null;
        interactUI.SetActive(false);
    }
}
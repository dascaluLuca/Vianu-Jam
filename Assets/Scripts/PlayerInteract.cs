using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    private Camera cam;
    [SerializeField] private float interactDistance = 3f;
    [SerializeField] private LayerMask interactMask; // Ce layere putem lovi (vom crea un layer in Unity)

    void Start()
    {
        cam = GetComponent<PlayerLook>().cam;
    }

    void Update()
    {
        UIManager.Instance.UpdatePrompt(""); // Ștergem promptul în fiecare frame, îl punem la loc doar dacă ne uităm la ceva

        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo, interactDistance, interactMask))
        {
            Interactable interactable = hitInfo.collider.GetComponent<Interactable>();
            if (interactable != null)
            {
                // Afișează pe ecran textul gen "Apasa E sa investighezi"
                UIManager.Instance.UpdatePrompt(interactable.promptMessage);
            }
        }
    }

    public void TryInteract()
    {
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo, interactDistance, interactMask))
        {
            Interactable interactable = hitInfo.collider.GetComponent<Interactable>();
            if (interactable != null)
            {
                interactable.Interact();
            }
        }
    }
}
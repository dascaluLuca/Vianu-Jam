using UnityEngine;

public class DeadComradeInteract : Interactable
{
    private bool hasInteracted = false;

    public override void Interact()
    {
        if (hasInteracted) return; // Ca să nu declanșeze povestea de 10 ori

        // Declanșăm gândul personajului
        UIManager.Instance.ShowThought("Un frate de arme... S-a sacrificat pentru nimic. Trebuie să-i fac un mormânt de pietre...", 6f);
        
        hasInteracted = true;
        promptMessage = ""; // Scoatem promptul ca sa nu mai zica "Apasa E"

        // Aici poți adăuga logica de progresie a questului (ex: activezi obiectivul de a strânge pietre)
    }
}
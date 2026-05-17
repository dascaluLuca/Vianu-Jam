using UnityEngine;

// O clasa abstracta: nu va fi pusa direct pe obiecte, ci vom face alte scripturi care o moștenesc
public abstract class Interactable : MonoBehaviour
{
    public string promptMessage = "Apasa E pentru a interacționa";
    
    // Funcția asta va fi suprascrisă de fiecare obiect în parte
    public abstract void Interact();
}
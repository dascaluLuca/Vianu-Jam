using UnityEngine;
using TMPro;
using System.Collections;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    [Header("UI Elements")]
    public TextMeshProUGUI thoughtText; // Textul de jos pentru poveste/gânduri
    public TextMeshProUGUI promptText;  // Textul din centru (ex: "Press E to Inspect")

    private void Awake()
    {
        // Setup Singleton
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    private void Start()
    {
        thoughtText.text = "";
        promptText.text = "";
    }

    // Funcție pe care o apelăm ca să arătăm un gând al personajului
    public void ShowThought(string message, float duration = 5f)
    {
        StopAllCoroutines(); // Oprim orice alt text care era deja pe ecran
        StartCoroutine(ThoughtRoutine(message, duration));
    }

    private IEnumerator ThoughtRoutine(string message, float duration)
    {
        thoughtText.text = message;
        yield return new WaitForSeconds(duration);
        thoughtText.text = ""; // Curăță textul după ce trece timpul
    }

    // Funcție pentru a afișa "Apasă E..."
    public void UpdatePrompt(string message)
    {
        promptText.text = message;
    }
}
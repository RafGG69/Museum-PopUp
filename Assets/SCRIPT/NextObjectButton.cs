using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class NextObjectButton : MonoBehaviour
{
    public SequentialObjectActivator objectActivator;

    private Button button;

    private void Start()
    {
        button = GetComponent<Button>();
        button.interactable = false; // Disable button initially
    }

    public void EnableButton()
    {
        button.interactable = true; // Enable button when needed
    }

    public void OnButtonPressed()
    {
        objectActivator.ActivateNextObject();
        button.interactable = false; // Disable button until the next activation
    }
}

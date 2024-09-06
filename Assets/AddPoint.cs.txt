using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AddPoint : MonoBehaviour
{
    public TMP_Text pointText;  // Reference to the UI text element to display points
    private int points = 0; // Current points

    // Start is called before the first frame update
    void Start()
    {
        UpdatePointText();
    }

    // Update the UI text to display the current points
    void UpdatePointText()
    {
        pointText.text = "Points: " + points.ToString();
    }

    // Add points to the total
    public void AddPoints(int amount)
    {
        points += amount;
        UpdatePointText();
    }

    // Subtract points from the total
    public void SubtractPoints(int amount)
    {
        points -= amount;
        UpdatePointText();
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This class inherits for the UIelement class and handles updating the fuel text
/// </summary>
public class FuelDisplay : UIelement
{
    [Tooltip("The text UI to use for display")]
    public Text displayText = null;

    /// <summary>
    /// Description:
    /// Updates the objective text
    /// Inputs:
    /// none
    /// Returns:
    /// void (no return)
    /// </summary>
    public void DisplayObjective()
    {
        if (displayText != null)
        {
            displayText.text = "Collect " + GameManager.fuelScore.ToString() + "/20 Fuel Pellets!";
        }
    }

    /// <summary>
    /// Description:
    /// Overides the virtual UpdateUI function and uses the DisplayScore to update the objective display
    /// Inputs:
    /// none
    /// Returns:
    /// void (no return)
    /// </summary>
    public override void UpdateUI()
    {
        // This calls the base update UI function from the UIelement class
        base.UpdateUI();

        // The remaining code is only called for this sub-class of UIelement and not others
        DisplayObjective();
    }
}

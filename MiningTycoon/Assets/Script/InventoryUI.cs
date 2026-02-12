using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    public TextMeshProUGUI ironText;

    public void UpdateUI(int ironCount)
    {
        ironText.text = "Iron : " + ironCount;
    }
}

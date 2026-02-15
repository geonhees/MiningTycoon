using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResourceUI : MonoBehaviour
{
    public TextMeshProUGUI ironText;
    public TextMeshProUGUI MoneyText;

    public void UpdateUI(int ironCount)
    {
        ironText.text = "Iron : " + ironCount;
        MoneyText.text = "Money : " + MoneyManager.Instance.money;
    }
}

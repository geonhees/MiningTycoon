using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MarketManager : MonoBehaviour
{
    public int ironPrice = 5;
    public float priceChangeTime = 60f;
    public static MarketManager Instance;
    public MarketUI marketUI;
    public ResourceUI resourceUI;

    public bool inMarket = false;

    private void Awake()
    {
        Instance = this;
        marketUI = FindObjectOfType<MarketUI>();
        resourceUI = FindObjectOfType<ResourceUI>();
        changePrice();
    }

    public void SellAllIron()
    {
        int iron = ResourceManager.Instance.ironCount;

        if (iron <= 0)
            return;

        int totalPrice = iron * ironPrice;

        ResourceManager.Instance.RemoveIron(iron);
        MoneyManager.Instance.AddMoney(totalPrice);
        resourceUI.UpdateUI(ResourceManager.Instance.ironCount);
    }
    void changePrice()
    {
        ironPrice = Random.Range(5, 10);
        Invoke(nameof(changePrice), priceChangeTime);
        marketUI.changeTimePriceText();
    }
}

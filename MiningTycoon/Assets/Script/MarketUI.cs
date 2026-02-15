using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MarketUI : MonoBehaviour
{
    public Button sellIronButton;
    public Image TimePricePanel;
    public Image sellPanel;
    public TextMeshProUGUI IronTimePrice;
    private bool isPlayerInMarket = false;
    private bool isPricePanelVisible = false;
    private bool isSellPanelVisible = false;

    void Start()
    {
        sellIronButton.onClick.AddListener(MarketManager.Instance.SellAllIron);
        sellPanel.gameObject.SetActive(isSellPanelVisible);
        TimePricePanel.gameObject.SetActive(isPricePanelVisible);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            showTimePrice();
        }
        if (Input.GetKeyDown(KeyCode.F) && isPlayerInMarket)
        {
            sellPanel.gameObject.SetActive(!isSellPanelVisible);
            MarketManager.Instance.inMarket = !isSellPanelVisible;
            Cursor.lockState = CursorLockMode.None;
            isSellPanelVisible = !isSellPanelVisible;
        }
        changeTimePriceText();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("시장 진입");
            isPlayerInMarket = true;
        }
    }
    public void changeTimePriceText()
    {
        IronTimePrice.text = $"Iron Price(5~10) : {MarketManager.Instance.ironPrice}";
    }
    public void showTimePrice()
    {
        TimePricePanel.gameObject.SetActive(!isPricePanelVisible);
        isPricePanelVisible = !isPricePanelVisible;
    }
}

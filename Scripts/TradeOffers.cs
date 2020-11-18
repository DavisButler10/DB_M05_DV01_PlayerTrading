using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;
using TMPro;
using UnityEngine.UI;

public class TradeOffers : MonoBehaviour
{
    [System.Serializable]
    public class TradeOfferInfo
    {
        public List<string> playerIds;
        public List<string> playerDisplayNames;
        public List<string> tradeIds;
    }

    public Button[] tradeOfferButtons;
    public List<TradeInfo> tradeOffers;
    public TradeOfferInfo tradeOfferInfo;
    private int numTradeOffers;
    // instance
    public static TradeOffers instance;
    void Awake() { instance = this; }

    public void UpdateTradeOffers()
    {
        DisableAllTradeOfferButtons();
    }
    void DisableAllTradeOfferButtons()
    {

    }
    void GetTradeInfo()
    {

    }
    void UpdateTradeOffersUI()
    {

    }
    public void OnTradeOfferButton(int tradeIndex)
    {

    }

}

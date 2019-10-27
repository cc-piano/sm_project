using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    public Counter userMoneyField;
    public Counter userCryptoField;
    public Button OpenStocksButton;
    public Button CloseStocksButton;
    public Button Clean;
    public Animator TrashAnim;
    public Animator DecorAnim;
    public GameObject Stocks;

    private void Start()
    {
        OpenStocksButton.onClick.AddListener(OpenStocks);
        CloseStocksButton.onClick.AddListener(CloseStocks);
        Clean.onClick.AddListener(ButtonClean);
    }

    private void OpenStocks()
    {
        Stocks.gameObject.SetActive(true);
        GameController.Instance.SoundController.FadeMain();
        GameController.Instance.SoundController.PlayStocks();
    }

    private void CloseStocks()
    {
        Stocks.gameObject.SetActive(false);
        GameController.Instance.SoundController.FadeStock();
        GameController.Instance.SoundController.PlayMain();
    }

    private void ButtonClean()
    {
        TrashAnim.enabled = true;
        DecorAnim.gameObject.SetActive(true);
    }
}

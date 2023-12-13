using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public TextMeshProUGUI _goldTxt;
    public TextMeshProUGUI _attackTxt;
    public TextMeshProUGUI _defenceTxt;
    public TextMeshProUGUI _healthTxt;
    public TextMeshProUGUI _speedTxt;

    public GameObject player;
    CharacterStatsHandler _characterStatsHandler;

    [SerializeField] private GameObject _status;
    [SerializeField] private GameObject _statusWindow;
    [SerializeField] private GameObject _inventory;
    [SerializeField] private GameObject _inventoryWindow;
    [SerializeField] private Button _exitStatusBtn;
    [SerializeField] private Button _exitInvenBtn;

    private void Awake()
    {
        instance = this;
        _characterStatsHandler = player.GetComponent<CharacterStatsHandler>();

        Button _statusBtn = _status.GetComponent<Button>();
        Button _inventoryBtn = _inventory.GetComponent<Button>();

        _statusBtn.onClick.AddListener(() => StatusWindowOpen(_statusWindow));
        _inventoryBtn.onClick.AddListener(() => StatusWindowOpen(_inventoryWindow));
        _exitStatusBtn.onClick.AddListener(() => ExitWindow(_statusWindow));
        _exitInvenBtn.onClick.AddListener(() => ExitWindow(_inventoryWindow));
    }

    private void ExitWindow(GameObject windowObject)
    {
        _status.SetActive(true);
        _inventory.SetActive(true);
        windowObject.SetActive(false);
    }

    private void StatusWindowOpen(GameObject windowObject)
    {
        _status.SetActive(false);
        _inventory.SetActive(false);
        windowObject.SetActive(true);
        _characterStatsHandler.CallStatusEvent(_characterStatsHandler.playerSo);
    }



    private void Update()
    {
        _goldTxt.text = _characterStatsHandler.Gold();
    }
}

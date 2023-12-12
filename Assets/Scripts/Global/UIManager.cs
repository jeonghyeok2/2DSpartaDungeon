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
    [SerializeField] private Button _exitBtn;

    private void Awake()
    {
        instance = this;
        _characterStatsHandler = player.GetComponent<CharacterStatsHandler>();

        Button _statusBtn = _status.GetComponent<Button>();
        Button _inventoryBtn = _inventory.GetComponent<Button>();

        _statusBtn.onClick.AddListener(() => StatusWindowOpen());
        _exitBtn.onClick.AddListener(() => ExitWindow());
    }

    private void ExitWindow()
    {
        _status.SetActive(true);
        _inventory.SetActive(true);
        _statusWindow.SetActive(false);
        //인벤토리 추가
    }

    private void StatusWindowOpen()
    {
        _status.SetActive(false);
        _inventory.SetActive(false);
        _statusWindow.SetActive(true);
        _characterStatsHandler.CallStatusEvent(_characterStatsHandler.playerSo);
    }



    private void Update()
    {
        _goldTxt.text = _characterStatsHandler.Gold();
    }
}

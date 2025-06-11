using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private Button buttonBack;
    [SerializeField] private GameObject slotPrefab;
    [SerializeField] private Transform slotParent;
    [SerializeField] private TMP_Text textInventoryCnt;

    private List<UISlot> slotList = new List<UISlot>();

    private void Start()
    {
        buttonBack.onClick.AddListener(() => UIManager.Instance.ShowMainMenu());
    }

    private void OnEnable()
    {
        InitInventoryUI();
    }

    private void InitInventoryUI()
    {
        // 기존 슬롯 제거
        foreach (Transform child in slotParent)
            Destroy(child.gameObject);
        slotList.Clear();

        var inventory = GameManager.Instance.Player.Inventory;
        textInventoryCnt.text = $"Inventory {inventory.Count} / 120";

        // 슬롯 생성
        foreach (Item item in inventory)
        {
            var go = Instantiate(slotPrefab, slotParent);
            var slot = go.GetComponent<UISlot>();
            slot.SetItem(item);
            slotList.Add(slot);
        }
    }
}
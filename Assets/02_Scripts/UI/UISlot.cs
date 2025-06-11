using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    [SerializeField] private TMP_Text textName;
    [SerializeField] private TMP_Text textDescription;
    [SerializeField] private GameObject equippedMark; // 장착 중 표시

    private Item item;

    public void SetItem(Item newItem)
    {
        item = newItem;
        RefreshUI();
    }

    private void RefreshUI()
    {
        textName.text = item.Name;
        textDescription.text = item.Description;
        equippedMark.SetActive(item.IsEquipped);
    }
}
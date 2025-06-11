using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    // 이름, 칭호, 레벨, 골드
    [SerializeField] private TMP_Text textTitle;
    [SerializeField] private TMP_Text textName;
    [SerializeField] private TMP_Text textLevel;
    [SerializeField] private TMP_Text textGold;

    // 경험치 
    [SerializeField] private Slider sliderExpBar;
    [SerializeField] private TMP_Text textExpValue;

    // 버튼
    [SerializeField] private Button btnStatus;
    [SerializeField] private Button btnInventory;

    // 캐릭터 정보를 받아서 UI에 표시
    public void SetCharacter(Character character)
    {
        textTitle.text = character.Title;
        textName.text = character.Name;
        textLevel.text = $"LV {character.Level}";
        textGold.text = $"{character.Gold:N0} G";

        sliderExpBar.value = character.Exp / 100f; // 예: 45%면 0.45
        textExpValue.text = $"{character.Exp} / 100";
    }

    private void Start()
    {
        // 버튼 클릭 
        btnStatus.onClick.AddListener(() => UIManager.Instance.ShowStatus());
        btnInventory.onClick.AddListener(() => UIManager.Instance.ShowInventory());
    }
}
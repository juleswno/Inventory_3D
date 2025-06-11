using UnityEngine;
using UnityEngine.UI;
using TMPro;

using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIStatus : MonoBehaviour
{
    [SerializeField] private TMP_Text numberAttack;
    [SerializeField] private TMP_Text numberDefense;
    [SerializeField] private TMP_Text numberHP;
    [SerializeField] private TMP_Text numberCritical;
    [SerializeField] private TMP_Text textGold;
    [SerializeField] private Button buttonBack;

    // 캐릭터 정보를 받아 텍스트 UI에 반영
    public void SetCharacter(Character character)
    {
        numberAttack.text = character.Attack.ToString();
        numberDefense.text = character.Defense.ToString();
        numberHP.text = character.HP.ToString();
        numberCritical.text = character.Critical.ToString();
        textGold.text = $"{character.Gold:N0} G";
    }

    private void Start()
    {
        // 뒤로가기 버튼 클릭 시 메인 메뉴로
        buttonBack.onClick.AddListener(() => UIManager.Instance.ShowMainMenu());
    }
}
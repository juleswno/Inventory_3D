using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private Button buttonBack;

    private void Start()
    {
        // 뒤로가기 클릭 시 메인 메뉴로
        buttonBack.onClick.AddListener(() => UIManager.Instance.ShowMainMenu());
    }
}
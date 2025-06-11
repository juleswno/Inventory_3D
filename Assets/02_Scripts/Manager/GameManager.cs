using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public Character Player { get; private set; }

    private void Awake()
    {
        // 싱글톤 설정
        if (Instance == null) Instance = this;
        else Destroy(gameObject);

        SetData(); // 초기 캐릭터 데이터 세팅
    }

    private void SetData()
    {
        // 테스트용 캐릭터 
        Player = new Character("Jules", "QUEEN", 27, 45, 14, 8, 9, 7, 20000);

        // UI에 캐릭터 정보 전달
        UIManager.Instance.UIMainMenu.SetCharacter(Player);
        UIManager.Instance.UIStatus.SetCharacter(Player);
    }
}
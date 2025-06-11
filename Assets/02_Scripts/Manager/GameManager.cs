using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public Character Player { get; private set; }

    private void Awake()
    {
        // 싱글톤 패턴
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // 씬 전환에도 유지
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        SetData();
    }

    /// <summary>
    /// 플레이어 및 게임 초기 데이터 설정
    /// </summary>
    private void SetData()
    {
        Player = new Character(
            name: "Jules",
            title: "QUEEN",
            level: 27,
            exp: 45,
            attack: 14,
            defense: 8,
            hp: 9,
            critical: 7,
            gold: 20000
        );

        // UI에 데이터 전달
        UIManager.Instance.UIMainMenu.SetCharacter(Player);
        UIManager.Instance.UIStatus.SetCharacter(Player);
    }
}
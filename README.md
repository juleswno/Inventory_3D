# Unity 인벤토리 시스템 구현

Unity 기반 텍스트 RPG에서 실제로 사용되는 인벤토리 시스템을 UGUI를 활용하여 구현한 프로젝트입니다.  
기본적인 UI 전환 기능부터 아이템 장착 및 상태 반영까지 단계별로 개발했습니다.

---

## 개발 환경

- **Unity 버전**: 2021.3 LTS 이상 권장  
- **언어**: C#
- **에디터**: Visual Studio / Rider

---

## 주요 기능

### 1. 메인 화면 구성 (`UIMainMenu`)
- 플레이어 정보 표시 (이름, 칭호, 레벨, 경험치, 설명, 골드)
- `Status` 및 `Inventory` 버튼으로 UI 전환

### 2. 상태창 (`UIStatus`)
- 캐릭터 능력치(공격력, 방어력, 체력, 치명타) 표시
- 현재 보유 골드 표시
- `뒤로가기 버튼`으로 메인화면 복귀

### 3. 인벤토리 (`UIInventory`)
- 동적으로 생성되는 슬롯 시스템
- 아이템 정보 표시 (이름, 설명, 장착 여부)
- 장착 중인 아이템은 별도 표시
- `뒤로가기 버튼`으로 메인화면 복귀

---

## 구조 설명

### 클래스 구성

| 클래스 | 역할 |
|--------|------|
| `GameManager` | 플레이어 데이터 생성 및 UI 초기화 |
| `UIManager` | 각 UI(Canvas) 관리 및 전환 |
| `Character` | 플레이어의 능력치, 인벤토리 데이터 포함 |
| `Item` | 이름, 설명, 장착 여부를 가진 아이템 데이터 |
| `UIMainMenu` | 메인 화면 UI 제어 |
| `UIStatus` | 캐릭터 상태창 UI 제어 |
| `UIInventory` | 인벤토리 슬롯 생성 및 UI 제어 |
| `UISlot` | 개별 아이템 슬롯 UI 처리 (장착 여부 포함) |

---

## 구현 사항 체크리스트

| 구현 항목 | 완료 여부 |
|-----------|------------|
| 메인 메뉴 UI 구성 | ✅ |
| Status UI 구성 | ✅ |
| Inventory UI 구성 | ✅ |
| UI 전환 기능 구현 | ✅ |
| Player 정보 표시 | ✅ |
| Slot 프리팹 생성 및 동적 인스턴스화 | ✅ |
| Item 클래스 및 인벤토리 리스트 구현 | ✅ |
| 아이템 장착 상태 표시 | ✅ |
| Canvas 정렬 순서 및 SetActive 전환 | ✅ |

---

## 실행 방법

1. Unity에서 프로젝트 열기
2. `MainScene` 실행
3. `GameManager` 오브젝트 자동 초기화
4. 메인화면에서 버튼 클릭으로 UI 전환
5. 인벤토리 슬롯, 상태 정보 확인

---

## 폴더 구조 (일부)

```Assets/
├── Scripts/
│   ├── Character.cs
│   ├── Item.cs
│   ├── GameManager.cs
│   └── UI/
│       ├── UIManager.cs
│       ├── UIMainMenu.cs
│       ├── UIStatus.cs
│       ├── UIInventory.cs
│       └── UISlot.cs
├── Prefabs/
│   └── UISlot.prefab
├── Scenes/
│   └── MainScene.unity```

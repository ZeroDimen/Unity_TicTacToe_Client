using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] private GameObject confirmPanel;
    
    // Main Scene에서 선택한 게임 타입
    private Constants.GameType _gameType;
    
    // Panel을 띄우기 위한 Canvas 정보
    private Canvas _canvas;
    
    public void ChangeToGameScene(Constants.GameType gameType) // Main에서 Game Scene으로 전환시 호출될 메서드
    {
        _gameType = gameType;
        SceneManager.LoadScene("Game");
    }
    
    public void ChangeToMainScene() // Game에서 Main Scene으로 전환시 호출될 메서드
    {
        SceneManager.LoadScene("Main");
    }
    public void OpenConfirmPanel(string message) // Confirm Panel을 띄우는 메서드
    {
        if (_canvas != null)
        {
            var confirmPanelObject = Instantiate(confirmPanel, _canvas.transform);
            confirmPanelObject.GetComponent<ConfirmPanelController>().Show(message);
        }
    }

    protected override void OnSceneLoad(Scene scene, LoadSceneMode mode)
    {
        _canvas = FindFirstObjectByType<Canvas>();
    }
}
using TMPro;
using UnityEngine;

public class ConfirmPanelController : PanelController
{
    [SerializeField] private TMP_Text messageText;


    public void Show(string message) // Confrim Panel을 표시하는 메서드
    {
        messageText.text = message;
        base.Show();
    }
    
    public void OnClickConfirmButton() // 확인 버튼 클릭시 호출되는 메서드
    {
        Hide();
    }
    
    public void OnClickCloseButton() // X 버튼 클릭시 호출되는 메서드
    {
        Hide();
    }
}

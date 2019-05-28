using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    // nếu là nhấn vào nút Play
    public void PlayGameButton()
    {
        Application.LoadLevel("ChonMucDo");
    }

    // nhấn nút giới thiệu
    public void GioiThieuButton()
    {
        Application.LoadLevel("CachChoi");
    }

    // Nhấn nút quit
    public void QuitGameButton()
    {
        Application.Quit();
    }

    // Nhấn nút chọn máy bay
    public void ChonMayBayButton()
    {
        Application.LoadLevel("ChonMayBay");
    }
}

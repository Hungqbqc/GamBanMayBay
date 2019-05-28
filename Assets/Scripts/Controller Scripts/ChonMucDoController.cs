using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChonMucDoController : MonoBehaviour
{
    // hàm chuyển sang màn hình chơi game tùy theo mức độ chọn game
    public void ChonMucDo(int MucDoId)
    {
        Enemy.MucDoId = MucDoId;
        Application.LoadLevel("GamePlay");
    }
}

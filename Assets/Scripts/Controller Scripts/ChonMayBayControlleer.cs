using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChonMayBayControlleer : MonoBehaviour
{
    public void ChonMayBay(int MayBayId)
    {
        Plane.mayBayId = MayBayId;
        Application.LoadLevel("ChonMucDo");
    }
}

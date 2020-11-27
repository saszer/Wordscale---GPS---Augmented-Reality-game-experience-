using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryPanelOpenClose : MonoBehaviour
{

    public GameObject inventorypanel;

    bool currentstate;

    public void OpenClose()
    {
        inventorypanel.SetActive(!currentstate);
        currentstate = !currentstate;
    }

}

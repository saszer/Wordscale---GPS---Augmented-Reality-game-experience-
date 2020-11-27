using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changecoloronclick : MonoBehaviour
{

    public void ClickYes()
    {
        GetComponent<Image>().color = Color.blue;
    }

    public void ClickNo()
    {
        GetComponent<Image>().color = Color.white;
    }

}

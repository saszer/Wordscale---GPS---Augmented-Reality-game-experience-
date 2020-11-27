using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnableDisableScripts : MonoBehaviour
{
    public UnityEvent clickon;
    public UnityEvent clickoff;

    bool currentstate;
    public void OpenClose()
    {
      if(currentstate == true)
        {
            clickon.Invoke();
        }

      if (currentstate == false)
        {
            clickoff.Invoke();
        }
        currentstate = !currentstate;
    }
}

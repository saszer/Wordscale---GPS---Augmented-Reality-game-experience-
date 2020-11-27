using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.EventSystems;
using UnityARInterface;
using UnityEngine.Events;
public class PlaceOnplane : MonoBehaviour
{
    public int playerchose;
    public GameObject[] objects;

    public GameObject Objecttospawn;
    public PlacementManager pcm;

    public UnityEvent eventsonspawned;

    public void PlayerChoseRose_Element0()
    {
        //Player chooses From Ui.
        //0 is Rose
        Objecttospawn = objects[playerchose];
    }



    void Start()
    {
        pcm = FindObjectOfType<PlacementManager>();
    }


    void Update()
    {

        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            GameObject obj = Instantiate(Objecttospawn, pcm.transform.position, pcm.transform.rotation);
            if(eventsonspawned != null)
            {
                eventsonspawned.Invoke();
            }
        }

    }
}

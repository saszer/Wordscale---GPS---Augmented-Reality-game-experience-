
using UnityEngine;

public class CollectionPoint : MonoBehaviour
{
    public AudioSource playthisonenter;
    public GameObject toenable;
    bool firstenter = false;
    void OnTriggerStay(Collider col)
    {
        if (col.gameObject.tag == "Player") 
        {
            Debug.Log("ya be collectin now");
            if (firstenter != true)
            {
                playthisonenter.Play();

                toenable.SetActive(true);

                firstenter = true;
            }

        }

    }
}

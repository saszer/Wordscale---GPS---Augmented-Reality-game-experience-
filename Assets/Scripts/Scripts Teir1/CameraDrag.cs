using UnityEngine;
using System.Collections;

public class CameraDrag : MonoBehaviour
{
    public float dragSpeed = 2;
    private Vector3 dragOrigin;

    public bool cameraDragging = true;

    public float outerLeft = -10f;
    public float outerRight = 10f;

    public float upperlimit = 10f;
    public float lowerlimit = -10f;




    private void Start()
    {
        upperlimit = this.transform.position.z + outerRight;
        lowerlimit = this.transform.position.z + outerRight;
    }

    void Update()
    {



        Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

        float left = Screen.width * 0.2f;
        float right = Screen.width - (Screen.width * 0.2f);

        float top = Screen.height * 0.2f;
        float bottom = Screen.height - (Screen.height * 0.2f);

        if (mousePosition.x < left)
        {
            cameraDragging = true;
        }
        else if (mousePosition.x > right)
        {
            cameraDragging = true;
        }

        else if (mousePosition.y > top)
        {
            cameraDragging = true;
        }
        else if (mousePosition.y > bottom)
        {
            cameraDragging = true;
        }





        if (cameraDragging)
        {

            if (Input.GetMouseButtonDown(0))
            {
                dragOrigin = Input.mousePosition;
                return;
            }

            if (!Input.GetMouseButton(0)) return;

            Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - dragOrigin);
            Vector3 move = new Vector3(pos.x * dragSpeed, 0 , pos.y * dragSpeed);

            if (move.x > 0f)
            {
               // if (this.transform.position.x < outerRight)
               // {
                    transform.Translate(move, Space.World);
               // }
            }
            else if (move.x < 0f)
            {
               // if (this.transform.position.x > outerLeft)
               // {
                    transform.Translate(move, Space.World);
               // }
            }

            if(move.z > 0f)
            {
               // if (this.transform.position.z < upperlimit)
               // {
                    transform.Translate(move, Space.World);
               // }
            }
            else if (move.z < 0f)
            {
               // if (this.transform.position.z > lowerlimit)
               // {
                    transform.Translate(move, Space.World);
               // }
            }
        }
    }


 }
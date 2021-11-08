using UnityEngine;

public class InputController : MonoBehaviour
{
    [SerializeField] private float rotateForce;

    private void FixedUpdate()
    {
        TouchHold();
    }

    private void TouchHold()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -rotateForce, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotateForce, 0);
        }


        //float screenSpace = Screen.width / 2;

        //Vector3 point = Input.mousePosition;

        //if (point.x > screenSpace)
        //{
        //    if (Input.GetMouseButton(0))
        //    {
        //        transform.Rotate(0, rotateForce, 0);
        //    }

        //}

        //if (point.x < screenSpace)
        //{
        //    if (Input.GetMouseButton(0))
        //    {
        //        transform.Rotate(0, -rotateForce, 0);
        //    }

        //}

    }

}

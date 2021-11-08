using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyInput : MonoBehaviour
{

    public static bool TouchBegin(out Vector3 point)
    {
#if UNITY_EDITOR
        point = Input.mousePosition;
        return Input.GetMouseButtonDown(0);
#else

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            point = touch.position;
            return touch.phase == TouchPhase.Began;
        }

        point = Vector3.zero;
        return false;
#endif
    }


    public static Vector3 TouchPosition()
    {

#if UNITY_EDITOR
        return Input.mousePosition;
        //#else
#else
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            return touch.position;
        }

        return Vector3.zero;
#endif
    }


    public static bool TouchHold()
    {
#if UNITY_EDITOR
        return Input.GetMouseButton(0);
#else
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            return touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary;
        }

        return false;
#endif
    }
    public static bool TouchHold(out Vector3 point)
    {
#if UNITY_EDITOR
        point = Input.mousePosition;
        return Input.GetMouseButton(0);
#else

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            point = touch.position;
            return touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary;
        }

        point = Vector3.zero;
        return false;
#endif
    }
}


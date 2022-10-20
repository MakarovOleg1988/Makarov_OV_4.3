using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Makarov_OV_4_3
{
    public class ChipMovingScript : ChipComponent
    {
        private Vector3 moffset;

        void onMouseDown()
        {
            moffset = gameObject.transform.position - GetmouseWorldPos();
        }
        

        private void OnMouseDrag()
        {
            if (_color == ColorType.White && TurnScript._turnScript._sideOfPlayer == false) transform.position = GetmouseWorldPos() + moffset;
            else if (_color == ColorType.Black && TurnScript._turnScript._sideOfPlayer == true) transform.position = GetmouseWorldPos() + moffset;
        }

        private Vector3 GetmouseWorldPos()
        {
            Vector3 mousePoint = Input.mousePosition;
            mousePoint.z = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

            return Camera.main.ScreenToWorldPoint(mousePoint);
        }

    }
}


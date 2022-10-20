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
        public string _targetCell = "Cell";

        void onMouseDown()
        {
            moffset = transform.position - GetmouseWorldPos();
            transform.GetComponent<Collider>().enabled = false;
        }

        private void OnMouseUp()
        {
            var _rayOrigin = Camera.main.transform.position;
            var _rayDirection = GetmouseWorldPos() - Camera.main.transform.position;
            RaycastHit _hitInfo;
            if (Physics.Raycast(_rayOrigin, _rayDirection, out _hitInfo))
            {
                if (_hitInfo.transform.tag == _targetCell && _color == ColorType.White && TurnScript._turnScript._sideOfPlayer == false)
                {
                    _chipWhite.transform.position = _hitInfo.transform.position;
                }
                else if (_hitInfo.transform.tag == _targetCell && _color == ColorType.Black && TurnScript._turnScript._sideOfPlayer == true)
                {
                    _chipBlack.transform.position = _hitInfo.transform.position;
                }

            }
            transform.GetComponent<Collider>().enabled = true;
        }

        private Vector3 GetmouseWorldPos()
        {
            Vector3 mousePoint = Input.mousePosition;
            mousePoint.z = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

            return Camera.main.ScreenToWorldPoint(mousePoint);
        }

    }
}


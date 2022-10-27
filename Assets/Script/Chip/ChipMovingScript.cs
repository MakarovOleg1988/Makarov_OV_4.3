using UnityEngine;

namespace Makarov_OV_4_3
{
    public class ChipMovingScript : ChipComponent
    {
        TurnScript _turnScript;
        private Vector3 moffset;
        [SerializeField] private float _distanceToPlayer;
        public string _targetCell = "Cell";

        private void OnMouseUp()
        {
            var _rayOrigin = Camera.main.transform.position;
            var _rayDirection = GetmouseWorldPos() - Camera.main.transform.position;
            RaycastHit _hitInfo;
            _distanceToPlayer = Vector3.Distance(transform.position, GetmouseWorldPos());
            if (Physics.Raycast(_rayOrigin, _rayDirection, out _hitInfo))
            {
                if (_hitInfo.transform.tag == _targetCell && _color == ColorType.White && TurnScript._turnScript._sideOfPlayer == false &&  _distanceToPlayer <= GetDistanceToTarget())
                {
                    _chipWhite.transform.position = _hitInfo.transform.position;
                    TurnScript._turnScript.TurnSide();
                }
                else if (_hitInfo.transform.tag == _targetCell && _color == ColorType.Black && TurnScript._turnScript._sideOfPlayer == true &&  _distanceToPlayer <= GetDistanceToTarget())
                {
                    _chipBlack.transform.position = _hitInfo.transform.position;
                    TurnScript._turnScript.TurnSide();
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

        public float GetDistanceToTarget()
        {
            float _distanceToTarget = 1.7f;
            float _distanceToBlackChip = Vector3.Distance(transform.position, _chipBlack.transform.position);
            float _distanceToWhiteChip = Vector3.Distance(transform.position, _chipWhite.transform.position);
            if (TurnScript._turnScript._sideOfPlayer == false && _distanceToBlackChip >= _distanceToTarget) _distanceToTarget = 1.7f;
            else _distanceToTarget = 1.7f * 2f;
            if (TurnScript._turnScript._sideOfPlayer == true && _distanceToWhiteChip >= _distanceToTarget) _distanceToTarget = 1.7f;
            else _distanceToTarget *= 2;
            return _distanceToTarget;
        }
    }
}


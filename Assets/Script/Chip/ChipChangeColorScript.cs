using UnityEngine;

namespace Makarov_OV_4_3
{
    public class ChipChangeColorScript : ChipComponent
    {
        public void OnMouseEnter()
        {
            if (_color == ColorType.White && TurnScript._turnScript._sideOfPlayer == false) GetComponent<MeshRenderer>().material = _meshMaterialsChips[2];
            else if (_color == ColorType.Black && TurnScript._turnScript._sideOfPlayer == false) Debug.Log("Вы пытаетесь выбрал чужую фишку");
            else if (_color == ColorType.Black && TurnScript._turnScript._sideOfPlayer == true) GetComponent<MeshRenderer>().material = _meshMaterialsChips[2];
            else if (_color == ColorType.White && TurnScript._turnScript._sideOfPlayer == true) Debug.Log("Вы пытаетесь выбрал чужую фишку");
        }

        public void OnMouseExit()
        {
            if (_color == ColorType.White && TurnScript._turnScript._sideOfPlayer == false) GetComponent<MeshRenderer>().material = _meshMaterialsChips[1];
            else if (_color == ColorType.Black && TurnScript._turnScript._sideOfPlayer == false) Debug.Log("Вы пытаетесь выбрал чужую фишку");
            else if (_color == ColorType.Black && TurnScript._turnScript._sideOfPlayer == true) GetComponent<MeshRenderer>().material = _meshMaterialsChips[0];
            else if (_color == ColorType.White && TurnScript._turnScript._sideOfPlayer == true) Debug.Log("Вы пытаетесь выбрал чужую фишку");
        }

        public void OnMouseDrag()
        {
            if (_color == ColorType.White && TurnScript._turnScript._sideOfPlayer == false) gameObject.GetComponent<MeshRenderer>().material = _meshMaterialsChips[3];
            else if (_color == ColorType.Black && TurnScript._turnScript._sideOfPlayer == true) gameObject.GetComponent<MeshRenderer>().material = _meshMaterialsChips[3];
        }
    }
}


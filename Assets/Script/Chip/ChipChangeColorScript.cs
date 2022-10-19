using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Makarov_OV_4_3
{
    public class ChipChangeColorScript : ChipComponent
    {
        private void OnMouseEnter()
        {
            if (_color == ColorType.White && TurnScript._turnScript._sideOfPlayer == false) GetComponent<MeshRenderer>().material = _meshMaterials[2];
            else if (_color == ColorType.Black && TurnScript._turnScript._sideOfPlayer == false) Debug.Log("Вы пытаетесь выбрал чужую фишку");
            else if (_color == ColorType.Black && TurnScript._turnScript._sideOfPlayer == true) GetComponent<MeshRenderer>().material = _meshMaterials[2];
            else if (_color == ColorType.White && TurnScript._turnScript._sideOfPlayer == true) Debug.Log("Вы пытаетесь выбрал чужую фишку");
        }

        private void OnMouseExit()
        {
            if (_color == ColorType.White && TurnScript._turnScript._sideOfPlayer == false) GetComponent<MeshRenderer>().material = _meshMaterials[1];
            else if (_color == ColorType.Black && TurnScript._turnScript._sideOfPlayer == false) Debug.Log("Вы пытаетесь выбрал чужую фишку");
            else if (_color == ColorType.Black && TurnScript._turnScript._sideOfPlayer == true) GetComponent<MeshRenderer>().material = _meshMaterials[0];
            else if (_color == ColorType.White && TurnScript._turnScript._sideOfPlayer == true) Debug.Log("Вы пытаетесь выбрал чужую фишку");
        }
    }
}

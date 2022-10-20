using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Makarov_OV_4_3
{
    public class TriggerWinScript : ChipComponent
    {

        public GameObject _panelWhiteWin;
        public GameObject _panelBlackWin;

        private void OnTriggerEnter(Collider other)
        {
            if (other.GetComponent<MeshRenderer>().material == _meshMaterialsChips[0])
            {
                _panelBlackWin.SetActive(true);
                Time.timeScale = 0f;
            } 
            else if (other.GetComponent<MeshRenderer>().material == _meshMaterialsChips[1])
            {
                _panelWhiteWin.SetActive(true);
                Time.timeScale = 0f;
            }
        }
    }
}

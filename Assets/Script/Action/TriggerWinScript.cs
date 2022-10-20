using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Makarov_OV_4_3
{
    public class TriggerWinScript : MonoBehaviour
    {

        public GameObject _panelWhiteWin;
        public GameObject _panelBlackWin;

        public void OnTriggerEnter(Collider other)
        {
            if (other.GetComponent<BlackChipClass>())
            {
                _panelBlackWin.SetActive(true);
                Time.timeScale = 0f;
            } 
            else if (other.GetComponent<WhteChipClass>())
            {
                _panelWhiteWin.SetActive(true);
                Time.timeScale = 0f;
            }
        }
    }
}

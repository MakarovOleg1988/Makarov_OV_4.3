using System.Collections;
using System;
using System.Threading.Tasks;
using UnityEngine;

namespace Makarov_OV_4_3
{
    public class TurnScript : MonoBehaviour
    {
        private Transform _player;
        public static TurnScript _turnScript;
        public bool _sideOfPlayer;

        void Start()
        {
            _player = GetComponent<Transform>();
            _turnScript = this;
        }

        public void TurnSide()
        {
            if (_sideOfPlayer == false)
            {
                StartCoroutine(TurnBlack());
                EventManager.SendTurnSide();
            }
            else if (_sideOfPlayer == true) StartCoroutine(TurnWhite());
        }

        public IEnumerator TurnBlack()
        {
            yield return new WaitForSeconds(1f);
            _player.transform.Rotate(Vector3.up, -180);
            _sideOfPlayer = true;
            yield return new WaitForSeconds(1f);
        }

        private IEnumerator TurnWhite()
        {
            yield return new WaitForSeconds(1f);
            _player.transform.Rotate(Vector3.up, 180);
            _sideOfPlayer = false;
            yield return new WaitForSeconds(1f);
        }
    }
}
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

        public void OnMouseDown()
        {
            if (_sideOfPlayer == false) StartCoroutine(TurnBlack());
            else if (_sideOfPlayer == true) StartCoroutine(TurnWhite());
        }

        private IEnumerator TurnBlack()
        {
            _player.transform.position = new Vector3(3.5f, 5.3f, -1f);
            _player.transform.Rotate(Vector3.up, 180);
            _sideOfPlayer = true;
            yield return new WaitForSeconds(1f);
        }

        private IEnumerator TurnWhite()
        {
            _player.transform.position = new Vector3(3.5f, 5.3f, 10f);
            transform.Rotate(Vector3.up, 180);
            _sideOfPlayer = false;
            yield return new WaitForSeconds(1f);
        }
    }
}
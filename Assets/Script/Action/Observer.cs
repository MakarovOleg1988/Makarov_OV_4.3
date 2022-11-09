using System;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Makarov_OV_4_3
{
    public class Observer : MonoBehaviour
    {

        string _action = "";

        private void Start()
        {
            if (TurnScript._turnScript._sideOfPlayer == false)  EventManager._onTurnSideBlack += OnObservedTurnBlack;
            else if (TurnScript._turnScript._sideOfPlayer == true) EventManager._onTurnSideBlack += OnObservedTurnWhite;
        }

        private void OnObservedTurnBlack()
        {
            _action = "Переход хода к черным";
            Debug.Log("Переход хода к черным");
        }

        private void OnObservedTurnWhite()
        {
            _action = "Переход хода к белым";
            Debug.Log("Переход хода к белым");
        }

        public void SaveReplay()
        {
            var action = _action;
            var _file = Environment.CurrentDirectory + "//ResultGame.txt";
            using (var _stream = File.Create(_file))
            {
                using (var _writer = new StreamWriter(_stream))
                {
                    _writer.WriteLine(action);
                }

                _stream.Close();
            }
        }
    }
}

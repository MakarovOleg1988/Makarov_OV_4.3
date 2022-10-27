using System;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Makarov_OV_4_3
{
    public class Observer : MonoBehaviour
    {

        string _action = "";

        private void Start() => EventManager._onTurnSide += OnObservedMessage;

        private void OnObservedMessage()
        {
            _action = "Переход хода к черным";
            Debug.Log("Переход хода");
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

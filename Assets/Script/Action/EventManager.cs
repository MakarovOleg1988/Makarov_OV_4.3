using System;
using UnityEngine;

namespace Makarov_OV_4_3
{
    public class EventManager : MonoBehaviour
    {
        public static event Action _onTurnSide;

        public static void SendTurnSide()
        {
            _onTurnSide?.Invoke();
        }
    }
}

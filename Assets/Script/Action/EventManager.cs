using System;
using UnityEngine;

namespace Makarov_OV_4_3
{
    public class EventManager : MonoBehaviour
    {
        public static event Action _onTurnSideBlack;
        public static event Action _onTurnSideWhite;

        public static void SendTurnSideBlack()
        {
            _onTurnSideBlack?.Invoke();
        }

        public static void SendTurnSideWhite()
        {
            _onTurnSideWhite?.Invoke();
        }
    }
}

using UnityEngine;

namespace Makarov_OV_4_3
{
    public class BlackChipClass: MonoBehaviour 
    {
        public static BlackChipClass _blackChipClass;

        private void Start()
        {
            _blackChipClass = this;
        }
    }
}

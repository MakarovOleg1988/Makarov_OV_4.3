using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Makarov_OV_4_3
{
    public class ChipComponent : MonoBehaviour
    {
        [SerializeField] protected Material[] _meshMaterials = new Material[3];
        [SerializeField] protected ColorType _color;

        public enum ColorType
        {
            White,
            Black
        }
    }
}

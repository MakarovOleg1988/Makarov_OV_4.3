using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Makarov_OV_4_3
{
    public abstract class ChipComponent : MonoBehaviour
    {

        [SerializeField] protected GameObject _chipWhite;
        [SerializeField] protected GameObject _chipBlack;
        protected GameObject _selectedChip;

        [SerializeField] protected Material[] _meshMaterialsChips = new Material[4];
        [SerializeField] protected ColorType _color;

        protected int _widhtBlack = 6;
        protected int _heightBlack = 3;

        protected int _widhtWhite = 6;
        protected int _heightWhite = 6;

        protected float _sizerowX = 1f;
        protected float _sizerowZ = 1f;

        public enum ColorType
        {
            White,
            Black
        }
    }
}

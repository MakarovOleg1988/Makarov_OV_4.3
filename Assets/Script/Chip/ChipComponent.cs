using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Makarov_OV_4_3
{
    public abstract class ChipComponent : MonoBehaviour
    {
        public ChipComponent _chipComponent;

        [SerializeField] protected GameObject _selectedBlock;
        [SerializeField] protected GameObject _chipWhite;
        [SerializeField] protected GameObject _chipBlack;
        [SerializeField] protected GameObject _selectedChip;
        [SerializeField] protected Material[] _meshMaterials = new Material[4];
        [SerializeField] protected ColorType _color;

        [SerializeField] protected int _widht;
        [SerializeField] protected int _height;

        protected float _sizerowX = 1f;
        protected float _sizerowZ = 1f;

        public enum ColorType
        {
            White,
            Black
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Makarov_OV_4_3
{
    public abstract class CellComponent : MonoBehaviour
    {
        [SerializeField] protected GameObject _blockBlack;
        [SerializeField] protected GameObject _blockWhite;
        [SerializeField] protected GameObject _selectedBlock;

        [SerializeField] protected Material[] _meshMaterialsCell = new Material[3];

        [SerializeField] protected int _widht;
        [SerializeField] protected int _height;

        protected float _sizerowX = 1f;
        protected float _sizerowZ = 1f;
        
    }
}

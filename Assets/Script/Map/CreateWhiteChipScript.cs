using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Makarov_OV_4_3
{
    public class CreateWhiteChipScript : MonoBehaviour
    {

        [SerializeField] private GameObject _chipWhite;

        [SerializeField] private int _widht;
        [SerializeField] private int _height;

        private float _sizerowX = 1f;
        private float _sizerowZ = 1f;

        void Start()
        {
            CreateChipWhite();
        }
        private void CreateChipWhite()
        {
            for (int x = 0; x <= _widht; x += 2)
            {
                for (int z = 8; z >= _height; z -= 1)
                {
                    float _xPos = x * _sizerowX;
                    float _zPos = z * _sizerowZ;

                    if (z % 2 == 1)
                    {
                        _xPos += _sizerowX;
                    }

                    GameObject _tempGo = Instantiate(_chipWhite, new Vector3(_xPos, 0.1f, _zPos), Quaternion.identity);

                    SetParentWhite(_tempGo, x, z);
                }
            }
        }

        void SetParentWhite(GameObject _tempGo, int x, int z)
        {
            _tempGo.transform.parent = transform;
            _tempGo.name = x.ToString() + "," + z.ToString();
        }
    }
}


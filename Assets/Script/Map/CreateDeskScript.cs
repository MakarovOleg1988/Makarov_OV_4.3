using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Makarov_OV_4_3
{
    public class CreateDeskScript : MonoBehaviour
    {

        [SerializeField] private GameObject _blockBlack;
        [SerializeField] private GameObject _blockWhite;

        [SerializeField] private int _widht;
        [SerializeField] private int _height;

        private float _sizerowX = 1f;
        private float _sizerowZ = 1f;

        void Start()
        {
            CreateMapBlockWhite();
            CreateMapBlockBlack();
        }

        private void CreateMapBlockWhite()
        {
            for (int x = 0; x <= _widht; x ++)
            {
                for (int z = 1; z <= _height; z += 2)
                {
                    float _xPos = x * _sizerowX;
                    float _zPos = z * _sizerowZ;

                    if (x % 2 == 1)
                    {
                        _zPos += _sizerowZ;
                    }

                    GameObject _tempGo = Instantiate(_blockWhite, new Vector3(_xPos, 0, _zPos), Quaternion.identity);

                    SetParentWhite(_tempGo, x, z);
                }
            }
        }

        void SetParentWhite(GameObject _tempGo, int x, int z)
        {
            _tempGo.transform.parent = transform;
            _tempGo.name = x.ToString() + "," + z.ToString();
        }

        private void CreateMapBlockBlack()
        {
            for (int x = 0; x <= _widht; x++)
            {
                for (int z = 2; z <= _height; z += 1)
                {
                    float _xPos = x * _sizerowX;
                    float _zPos = z * _sizerowZ;

                    if (x % 2 == 1)
                    {
                        _zPos -= _sizerowZ;
                    }

                    GameObject _tempGo = Instantiate(_blockBlack, new Vector3(_xPos, 0, _zPos), Quaternion.identity);

                    SetParentBlack(_tempGo, x, z);
                }
            }
        }

        void SetParentBlack(GameObject _tempGo, int x, int z)
        {
            _tempGo.transform.parent = transform;
            _tempGo.name = x.ToString() + "," + z.ToString();
        }
    }
}


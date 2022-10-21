using UnityEngine;

namespace Makarov_OV_4_3
{
    public class CreateChipScript : ChipComponent
    {

        void Start()
        {
            CreateChipBlack();
            CreateChipWhite();
        }
        private void CreateChipBlack()
        {
            for (int x = 0; x <= _widhtBlack; x += 2)
            {
                for (int z = 1; z <= _heightBlack; z += 1)
                {
                    float _xPos = x * _sizerowX;
                    float _zPos = z * _sizerowZ;

                    if (z % 2 == 1)
                    {
                        _xPos += _sizerowX;
                    }

                    GameObject _tempGo = Instantiate(_chipBlack, new Vector3(_xPos, 0.1f, _zPos), Quaternion.identity);

                    SetParentBlack(_tempGo, x, z);
                }
            }
        }

        void SetParentBlack(GameObject _tempGo, int x, int z)
        {
            _tempGo.transform.parent = transform;
            _tempGo.name = "Chip " + x.ToString() + "," + z.ToString();
        }

        private void CreateChipWhite()
        {
            for (int x = 0; x <= _widhtWhite; x += 2)
            {
                for (int z = 8; z >= _heightWhite; z -= 1)
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
            _tempGo.name = "Chip " + x.ToString() + "," + z.ToString();
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Makarov_OV_4_3
{
    public class ChipMovingScript : ChipComponent
    {

        private void OnMouseDown()
        {

        }

        /*private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray _ray = Camera.main.ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1));
                RaycastHit _hit;
                while (Physics.Raycast(_ray, out _hit, Mathf.Infinity) && TurnScript._turnScript._sideOfPlayer == false && gameObject.GetComponent<ChipComponent>())
                {
                        _selectedChip = _hit.transform.gameObject;
                        _selectedChip.GetComponent<MeshRenderer>().material = _meshMaterials[3];
                    Instantiate(_selectedBlock, _selectedChip.transform.position + new Vector3(1, 0, -1), Quaternion.identity);
                    Instantiate(_selectedBlock, _selectedChip.transform.position + new Vector3(-1, 0, -1), Quaternion.identity);
                    Debug.Log("createnew");
                }
            }
        }*/

        IEnumerator Move()
        {
            GameObject _objectMove = _selectedChip;
            while (Vector3.Distance(_selectedChip.transform.position, gameObject.transform.position) > 0.01f)
            {
                _objectMove.transform.position = Vector3.MoveTowards(_objectMove.transform.position, transform.position, 0.01f);
                yield return new WaitForSeconds(0.01f);
            }
        }
    }
}

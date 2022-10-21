using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Makarov_OV_4_3
{
    public class ChipKillEnemy : MonoBehaviour
    {
        public void OnTriggerEnter(Collider other)
        {
            if (other.GetComponent<BlackChipClass>())
            {
                Destroy(this.gameObject);
            }
            else if (other.GetComponent<WhteChipClass>())
            {
                Destroy(this.gameObject);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Animal"))
        {
            PointsManager.instance.AlterPoints(10);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}

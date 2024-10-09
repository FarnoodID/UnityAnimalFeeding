using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsZ : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Debug.Log("Good Boy!");
        other.transform.rotation = Quaternion.Euler(other.transform.rotation.eulerAngles.x, 90, other.transform.rotation.eulerAngles.z);
    }
}

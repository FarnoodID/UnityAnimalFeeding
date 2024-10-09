using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > 25 || transform.position.z < -10)
        {
            Destroy(gameObject);
        }
    }
}

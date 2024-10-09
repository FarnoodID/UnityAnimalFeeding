using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogController : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (transform.position.x < -31 )
        {
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, 90, transform.rotation.eulerAngles.z);
        }
        else if (transform.position.x > 15)
        {
            transform.position = new Vector3(15, transform.position.y, transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.Space) && transform.position.x >= 15)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, -90, transform.rotation.eulerAngles.z);
        }
    }
}

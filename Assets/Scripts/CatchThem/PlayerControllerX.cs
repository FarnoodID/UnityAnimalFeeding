using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float canJump = 0f;
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > canJump)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            canJump = Time.time + 1f;
        }
    }
}

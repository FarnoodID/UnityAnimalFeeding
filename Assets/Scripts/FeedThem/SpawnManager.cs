using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] pref;
    private int n;
    private float range;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn", 2, 1.5f);
    }
    void spawn ()
    {
        n = Random.Range(0, pref.Length);
        range = Random.Range(-19, 19);
        Instantiate(pref[n], new Vector3(range, 0, 20), pref[n].transform.rotation);
    }
}

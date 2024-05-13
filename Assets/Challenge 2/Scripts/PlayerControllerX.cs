using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float targetTime = 2f;
    public float _canpress = 0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) & (_canpress < Time.time))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            _canpress = Time.time + targetTime;
        };


    }
}

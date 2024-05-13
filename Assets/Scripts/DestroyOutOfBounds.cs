using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float zBound = 30f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Destroy objects that are sent too far above the screen
        if (transform.position.z > zBound)
        {
            Destroy(gameObject);
        }

        // Destroy objects that are sent too far below the screen
        if (transform.position.z > zBound)
        {

            // if an object gets passed player, log Game Over!
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    // declare new dogPrefab variable of type GameObject
    public GameObject dogPrefab;

    // instantiate float variables for delay between dog spawns by player
    private float delay = 0;
    private float maxDelay = 1.0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // player can't spam dogs if delay <=0, otherwise dog is instantiated
            if (delay <= 0)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                delay = maxDelay;
            }
        }

        // when delay is > 0, keep decreasing by Time.deltaTime until delay <=0
        if (delay > 0)
        {
            delay -= Time.deltaTime;
        }
    }
}

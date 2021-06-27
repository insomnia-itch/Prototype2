using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timePressed = 0;
    public float dogInterval = 0.35f;
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && (Time.time - timePressed > dogInterval))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timePressed = Time.time;
        }
    }
}

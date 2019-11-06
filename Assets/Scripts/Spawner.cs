using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject minionPrefab;

    float timer = 3f;

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer = 3f;
            Instantiate(minionPrefab, transform.position, transform.rotation);
        }
    }
}

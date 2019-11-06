using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //kill minion
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("minion")) {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }
    }
}

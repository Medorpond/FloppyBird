using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheObs : MonoBehaviour
{
    [SerializeField] private float theSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -10) { Destroy(gameObject); }
        transform.Translate(Vector3.left * theSpeed * Time.deltaTime);
    }
}

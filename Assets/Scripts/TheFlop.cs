using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheFlop : MonoBehaviour
{
    [SerializeField] private float theStrength = 250f;
    [SerializeField] private GameManager theManager;
    private Rigidbody2D theBody;
    void Start()
    {
        theBody = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            theBody.AddForce(transform.up * theStrength);
            Debug.Log("Up");
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        theManager.theOver();
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Point +1");
    }
}

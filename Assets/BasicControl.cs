using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicControl : MonoBehaviour
{
    public float speed = 1.0f;

    private GameObject thisObject;

    // Start is called before the first frame update
    void Start()
    {
        thisObject = this.gameObject;
        Debug.Log("Game start!");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        thisObject.transform.position += (Vector3) input * speed;
    }
}

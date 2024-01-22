using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController2 : MonoBehaviour
{
    // Start is called before the first frame update
    [Range(0,10f)]
    public float speed;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float X_movement = Input.GetAxis("Horizontal");
        float Y_movement = Input.GetAxis("Vertical");
        transform.position += (new Vector3(X_movement, Y_movement, 0)) * speed * Time.deltaTime;
    }
}

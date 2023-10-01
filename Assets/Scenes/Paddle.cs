using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float MoveSpeed = 10f;
    public float MoveRange = 10f;
    public bool AceptsInput = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!AceptsInput)
            return;

        float input = Input.GetAxis("Vertical");
        Vector3 pos = transform.position;
        pos.z += input * MoveSpeed * Time.deltaTime;
        pos.z = Mathf.Clamp(pos.z, -MoveRange, MoveRange);
        transform.position = pos;
    }
}

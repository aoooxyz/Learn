using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LunaController : MonoBehaviour
{
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal"); // A/D 或 左右键
        Vector3 position = transform.position;
        position.x += moveX * speed * Time.deltaTime;
        transform.position = position;
    }
}

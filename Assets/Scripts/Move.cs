using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public static Vector3 Right = Vector3.right;
    
    private float speed = 5f;

    void Update()
    {
        transform.Translate(Right * speed * Time.deltaTime);
    }
}

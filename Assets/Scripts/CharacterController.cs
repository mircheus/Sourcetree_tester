using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private void Update()
    {
        Move();
        Rotate();
    }

    private void Move()
    {
        Debug.Log("Moving");
    }

    private void Rotate()
    {
        Debug.Log("Rotate");
    }
}

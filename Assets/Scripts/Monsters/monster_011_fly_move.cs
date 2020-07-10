using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monster_011_fly_move : MonoBehaviour
{
    private float MoveSpeed = 5f;

    void AddSpeed(float Speed)
    {
        MoveSpeed -= Speed;
        return;
    }

    void FixedUpdate()
    {
        float H = Input.GetAxis("Horizontal");
        float V = Input.GetAxis("Vertical");
        this.transform.position += new Vector3(MoveSpeed * H * Time.deltaTime, MoveSpeed * V * Time.deltaTime, 0);
    }
}

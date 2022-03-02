using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5.5f, -7);
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
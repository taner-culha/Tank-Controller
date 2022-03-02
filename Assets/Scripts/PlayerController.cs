using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float turnSpeed;
    [SerializeField] private float horizontalI;
    [SerializeField] private float forwardI;
    void Update()
    {
        horizontalI = Input.GetAxis("Horizontal");
        forwardI = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed* forwardI);
        transform.Rotate(Vector3.up, turnSpeed* horizontalI * Time.deltaTime);
    }
}
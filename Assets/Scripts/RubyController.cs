using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vericial = Input.GetAxis("Vertical");

        Vector2 position = transform.position;
        position.x = position.x + 3f * horizontal * Time.deltaTime;
        position.y = position.y + 3f * vericial * Time.deltaTime;
        transform.position = position;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float x_cor = Input.GetAxis("Horizontal");
        transform.Translate(x_cor, 0, 0);
    }
}

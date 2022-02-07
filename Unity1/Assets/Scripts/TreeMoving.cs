using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TreeMoving : MonoBehaviour
{
    private double endPlace = 0;
    private int direction = 1;
    [SerializeField]
    private Text time;

    // Start is called before the first frame update
    void Start()
    {
        endPlace = System.Math.Round(Random.Range(0.01f, 9f), 2);
    }

    // Update is called once per frame
    void Update()
    {
        if (System.Math.Round(transform.position.x, 3) == endPlace)
        {
            if (direction == 0)
            {
                endPlace = System.Math.Round(Random.Range(transform.position.x, 9f), 2);
                direction = 1;
            }
            else
            {
                endPlace = System.Math.Round(Random.Range(-9f, transform.position.x), 2);
                direction = 0;
            }
        }
        else
        {
            if (direction == 0)
            {
                transform.position = new Vector3((float)System.Math.Round(transform.position.x - 0.01f, 2), transform.position.y, transform.position.z);
            }
            else
            {
                transform.position = new Vector3((float)System.Math.Round(transform.position.x + 0.01f, 2), transform.position.y, transform.position.z);
            }
        }
    }
}

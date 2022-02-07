using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class BasketMoving : MonoBehaviour
{
    [SerializeField]
    private Text score;
    [SerializeField]
    private AudioSource appleCatch;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(Input.mousePosition.x * Time.deltaTime, transform.position.y, transform.position.z);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        int currentScore = System.Convert.ToInt32(score.text);
        score.text = (currentScore + Random.Range(45, 56)).ToString();
        appleCatch.Play();
    }
}

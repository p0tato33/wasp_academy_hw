using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GroundCol : MonoBehaviour
{
    private bool isFirstBasketAlive = true;
    private bool isSecondBasketAlive = true;
    [SerializeField]
    private GameObject firstBasket;
    [SerializeField]
    private GameObject secondBasket;
    [SerializeField]
    private GameObject lastBasket;
    [SerializeField]
    private Text score;
    [SerializeField]
    private AudioSource appleFall;

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        int currentScore = System.Convert.ToInt32(score.text);
        score.text = (currentScore - 250).ToString();

        if (isFirstBasketAlive)
        {
            isFirstBasketAlive = false;
            firstBasket.SetActive(false);
            appleFall.Play();
        }
        else if (isSecondBasketAlive)
        {
            isSecondBasketAlive = false;
            secondBasket.SetActive(false);
            appleFall.Play();
        }
        else
        {
            isFirstBasketAlive = true;
            isSecondBasketAlive = true;

            firstBasket.SetActive(true);
            secondBasket.SetActive(true);
            appleFall.Play();
        }
    }
}

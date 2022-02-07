using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountTime : MonoBehaviour
{
    [SerializeField]
    private Text time;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Count());
    }

    private void Repeat()
    {
        StartCoroutine(Count());
    }

    private IEnumerator Count()
    {
        yield return new WaitForSeconds(1f);
        time.text = (System.Convert.ToInt32(time.text) + 1).ToString();
        Repeat();
    }
}

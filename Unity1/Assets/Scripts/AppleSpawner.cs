using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject apple;
    [SerializeField]
    private Transform spawnPos;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCD());
    }

    private void Repeat()
    {
        StartCoroutine(SpawnCD());
    }

    private IEnumerator SpawnCD()
    {
        yield return new WaitForSeconds(1f);
        Instantiate(apple, spawnPos.position, Quaternion.identity);
        Repeat();
    }
}

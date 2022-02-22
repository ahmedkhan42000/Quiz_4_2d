using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WavesShooter : MonoBehaviour
{
    public GameObject[] WavesCount;
    // Start is called before the first frame update
    void Start()
    {
       GameObject gameObject = WavesCount[0];
       gameObject.SetActive(true);
       //gameObject.transform.position = new Vector2(0,0);
    }

    // Update is called once per frame
    void Update()
    {
        if (WavesCount[0].GetComponentInChildren<Transform>().childCount == 0)
        {
            WavesCount[0].SetActive(false);
            GameObject gameObject = WavesCount[1];
            gameObject.SetActive(true);
        }
        if (WavesCount[1].GetComponentInChildren<Transform>().childCount == 0)
        {
            WavesCount[1].SetActive(false);
            GameObject gameObject = WavesCount[2];
            gameObject.SetActive(true);
        }
    }
}

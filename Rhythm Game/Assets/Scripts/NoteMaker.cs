using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteMaker : MonoBehaviour
{
    AudioSource bpmCount;
    public AudioClip bpm;
    float stdBpm = 60f;
    float musicBpm = 60f;

    float countTime = 0;
    float nextTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        bpmCount = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        countTime = stdBpm / musicBpm;
        nextTime += Time.deltaTime;

        if(nextTime > countTime)
        {
            StartCoroutine(playCount(countTime));
            nextTime = 0;
        }
    }

    IEnumerator playCount(float countTime)
    {
        Debug.Log(nextTime);
        bpmCount.PlayOneShot(bpm);
        yield return new WaitForSeconds(countTime);
    }
}

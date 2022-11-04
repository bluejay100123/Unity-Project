using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Editor : MonoBehaviour
{
    static Editor instance;
    public static Editor Instance
    {
        get
        {
            return instance;
        }
    }

    public int currentBar = 0;
    public float offsetPosition;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    float speed;
    public void Init()
    {

        StartCoroutine(IEBarTimer());

        //speed = 16 / GameManager.Instance.sheets[GameManager.Instance.title].BarPerSec;
        //offsetPosition = speed * GameManager.Instance.sheets[GameManager.Instance.title].offset * 0.001f;
        //objects.transform.position = offsetPosition * Vector3.up;
    }

    public void CaculateCurrnetBar()
    {
        currentBar = (int)(AudioManager.Instance.progressTime * 1000 / GameManager.Instance.sheets[GameManager.Instance.title].MilliSecPerBar);
    }

    IEnumerator IEBarTimer()
    {
        WaitForSeconds wait = new WaitForSeconds(0.1f);
        while (true)
        {
            CaculateCurrnetBar();
            yield return wait;
        }
    }
}

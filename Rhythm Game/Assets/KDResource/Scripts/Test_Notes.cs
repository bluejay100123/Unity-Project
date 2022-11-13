using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Notes : MonoBehaviour
{
    public float noteSpeed = 400; // 노트 내려가는 속도

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition += Vector3.down * noteSpeed * Time.deltaTime;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Override로 따로 함수 구현해서 4키,6키,8키 모드?
        switch (Input.inputString) {
            case "D":
                Debug.Log("D");
                break;
            case "F":
                Debug.Log("F");
                break;
            case "J":
                Debug.Log("J");
                break;
            case "K":
                Debug.Log("K");
                break;
            default:
                break;
        }
    }
}

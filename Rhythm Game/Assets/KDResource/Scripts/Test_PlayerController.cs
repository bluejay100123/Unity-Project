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
        //Override�� ���� �Լ� �����ؼ� 4Ű,6Ű,8Ű ���?
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

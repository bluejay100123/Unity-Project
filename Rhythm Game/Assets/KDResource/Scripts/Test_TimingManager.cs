using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_TimingManager : MonoBehaviour
{
    public List<GameObject> boxNoteList = new List<GameObject>();

    [SerializeField] Transform Center = null; // Judgeline ������Ʈ
    [SerializeField] RectTransform[] timingRect = null; // Perfect, Good, Nice, Bad
    Vector2[] timingBoxes = null; // x: �ּ�, y: �ִ�

    // Start is called before the first frame update
    void Start()
    {
        //timing �ڽ� ����
        timingBoxes = new Vector2[timingRect.Length]; // ���� �迭 ũ�⸸ŭ
        for(int i = 0; i < timingRect.Length; i++)
        {
            timingBoxes[i].Set(Center.localPosition.y - timingRect[i].rect.height / 2, 
                Center.localPosition.y + timingRect[i].rect.height / 2);
        }
    }

    public void CheckTiming()
    {
        for(int i = 0; i < boxNoteList.Count; i++)
        {
            float t_notePosY = boxNoteList[i].transform.localPosition.y;
            for(int y = 0; y < timingBoxes.Length; y++)
            {
                if(timingBoxes[y].x <= t_notePosY && t_notePosY <= timingBoxes[y].y)
                {
                    Debug.Log("Hit" + y);
                    return;
                }
            }
        }
        Debug.Log("Miss");
    }
}

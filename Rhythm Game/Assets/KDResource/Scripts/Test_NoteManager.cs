using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_NoteManager : MonoBehaviour
{
    public int bpm = 0;
    double currentTime = 0d;

    [SerializeField] Transform[] tfNoteAppear = null; // 노트 생성 위치 EmptyObject, 1,2,3,4라인 추가
    [SerializeField] GameObject goNote = null; // 노트

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if(currentTime >= 60d / bpm)
        {
            GameObject t_note = Instantiate(goNote, tfNoteAppear[0].position, Quaternion.identity);
            t_note.transform.SetParent(this.transform);
            currentTime -= 60d / bpm; // 시간 오차 발생(소수점 단위0.0044...등) 시 다음 if문에서 더해져 오차 상쇄
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Note"))//롱, 숏 구분하기
        {
            Destroy(collision.gameObject);
        }
    }
}

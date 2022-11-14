using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_NoteManager : MonoBehaviour
{
    public int bpm = 0;
    double currentTime = 0d;

    [SerializeField] Transform[] tfNoteAppear = null; // ��Ʈ ���� ��ġ EmptyObject, 1,2,3,4���� �߰� -> �ʿ����
    [SerializeField] GameObject goNote = null; // ��Ʈ

    Test_TimingManager tstTimingManager;

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
            tstTimingManager.boxNoteList.Add(t_note);
            currentTime -= 60d / bpm; // �ð� ���� �߻�(�Ҽ��� ����0.0044...��) �� ���� if������ ������ ���� ���
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Note"))//��, �� �����ϱ�
        {
            tstTimingManager.boxNoteList.Remove(collision.gameObject);
            Destroy(collision.gameObject);
        }
    }
}

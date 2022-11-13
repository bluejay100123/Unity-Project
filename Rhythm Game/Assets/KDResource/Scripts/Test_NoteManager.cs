using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_NoteManager : MonoBehaviour
{
    public int bpm = 0;
    double currentTime = 0d;

    [SerializeField] Transform[] tfNoteAppear = null; // ��Ʈ ���� ��ġ EmptyObject, 1,2,3,4���� �߰�
    [SerializeField] GameObject goNote = null; // ��Ʈ

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
            currentTime -= 60d / bpm; // �ð� ���� �߻�(�Ҽ��� ����0.0044...��) �� ���� if������ ������ ���� ���
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Note"))//��, �� �����ϱ�
        {
            Destroy(collision.gameObject);
        }
    }
}

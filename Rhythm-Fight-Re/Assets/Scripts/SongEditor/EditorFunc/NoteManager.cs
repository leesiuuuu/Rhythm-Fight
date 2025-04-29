using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static EditorEnum;

public class NoteManager : MonoBehaviour
{
    public List<NoteInfo> notes = new List<NoteInfo>();
    
    //필드에 노트 추가하기
    public void AddNote(NoteInfo note)
    {
        notes.Add(note);
    }
}
public class NoteInfo
{
    public NoteType Type;
    public double Time;
    public int Pos;

    public NoteEvent noteEvent = NoteEvent.None;

    public NoteInfo(NoteType type, double time, int pos)
    {
        Type = type; Time = time; Pos = pos;
    }
    public void SetEvent(NoteEvent noteEvent) => this.noteEvent = noteEvent;
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditorEnum : MonoBehaviour
{
	
}
public enum BGType
{
	Stadium,
	Limousine,
	Beach
}
public enum NoteType
{
	Normal,
	Cure,
	Long,
	Double
}
public enum EventType
{
	BG,
	Note
}
public enum NoteEvent
{
	None,
	ChangeDir,
	Invisible
}
public enum BGEvent
{
	None
}

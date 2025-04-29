using UnityEngine;

public static class EditorEnum
{
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
}
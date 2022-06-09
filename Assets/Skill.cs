public class Skill
{
	private bool _know;           


	public bool Know
	{
		get { return _know; }
		set { _know = value; }
	}
}

public enum SkillName
{
	Melee_Offense,
	Melee_Defense,
	Range_Offense,
	Range_Defense,
	Magic_Offense,
	Magic_Defense
}
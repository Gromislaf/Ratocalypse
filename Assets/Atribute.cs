public class Attribute : BaseStat
{
	new public const int STARTTING_EXP_COST = 50;   
	public Attribute()
	{
		ExpToLevel = STARTTING_EXP_COST;
		LevelModifier = 1.05f;
	}
}

public enum AttributeName
{
	Might,
	Constitution,
	Nimbleness,
	Speed,
	Concentration,
	WillPower,
	Charisma
}
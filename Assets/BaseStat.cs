public class BaseStat
{

	public const int STARTTING_EXP_COST = 100;  

	private int _baseValue;                     
	private int _buffValue;                   
	private int _expToLevel;                   
	private float _levelModifier;            
	private string _name;                          

	
	public BaseStat()
	{
		_baseValue = 0;
		_buffValue = 0;
		_levelModifier = 1.1f;
		_expToLevel = STARTTING_EXP_COST;
		_name = string.Empty;
	}

	#region Propperties

	public int BaseValue
	{
		get { return _baseValue; }
		set { _baseValue = value; }
	}


	public int BuffValue
	{
		get { return _buffValue; }
		set { _buffValue = value; }
	}

	
	public int ExpToLevel
	{
		get { return _expToLevel; }
		set { _expToLevel = value; }
	}

	public float LevelModifier
	{
		get { return _levelModifier; }
		set { _levelModifier = value; }
	}


	public string Name
	{
		get { return _name; }
		set { _name = value; }
	}
	#endregion


	private int CalculateExpToLevel()
	{
		return (int)(_expToLevel * _levelModifier);
	}

	public void LevelUp()
	{
		_expToLevel = CalculateExpToLevel();
		_baseValue++;
	}


	public int AdjustedBaseValue
	{
		get { return _baseValue + _buffValue; }
	}
}
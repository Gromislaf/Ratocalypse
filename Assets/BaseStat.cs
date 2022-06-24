


	private string _name;							//This is the name of the attribute
	
	/// <summary>
	/// Initializes a new instance of the <see cref="BaseStat"/> class.
	/// </summary>
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

	/// <summary>
	/// Gets or sets the _levelModifier.
	/// </summary>
	/// <value>
	/// The _levelModifier.
	/// </value>
	public float LevelModifier
	{
		get { return _levelModifier; }
		set { _levelModifier = value; }
	}

	public string Name
	{
	}
	#endregion

	private int CalculateExpToLevel()
	{
		return (int)(_expToLevel * _levelModifier);
	}

	/// <summary>
	/// Assign a new value to _expToLevel and then increase the _baseLevel by one.
	/// </summary>
	public void LevelUp()
	{
		_expToLevel = CalculateExpToLevel();
	}

	public int AdjustedBaseValue
	{
	}
}
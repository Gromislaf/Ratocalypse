using UnityEngine;
using System.Collections;
using System;

public class BaseCharacter : MonoBehaviour
{

	private string _name;
	private int _level;
	private uint _freeExp;

	private Attribute[] _primaryAttribute;

	private Skill[] _skill;

	public void Awake()
	{
		_name = String.Empty;
		_level = 0;
		_freeExp = 0;

		_primaryAttribute = new Attribute[Enum.GetValues(typeof(AttributeName)).Length];
	

	
	}

	#region Properties	
	public string Name
	{
		get
		{
			return this._name;
		}
		set
		{
			_name = value;
		}
	}
	public int Level
	{
		get
		{
			return this._level;
		}
		set
		{
			_level = value;
		}
	}
	public uint FreeExp
	{
		get
		{
			return this._freeExp;
		}
		set
		{
			_freeExp = value;
		}
	}
	#endregion

	public void AddExp(uint exp)
	{
		_freeExp += exp;

		CalculateLevel();
	}

	//take avg of all player skills and assign  that as the player level
	public void CalculateLevel()
	{

	}

	private void SetupPrimaryAttributes()
	{
		for (int cnt = 0; cnt < _primaryAttribute.Length; cnt++)
		{
			_primaryAttribute[cnt] = new Attribute();
			_primaryAttribute[cnt].Name = ((AttributeName)cnt).ToString();
		}
	}



	public Attribute GetPrimaryAttribute(int index)
	{
		return _primaryAttribute[index];
	}


	public Skill GetSkill(int index)
	{
		return _skill[index];
	}

	
}
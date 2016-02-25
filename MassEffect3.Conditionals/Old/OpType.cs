﻿namespace MassEffect3.Conditionals
{
	public enum OpType : byte
	{
		StaticBool = 0,
		StaticInt = 1,
		StaticFloat = 2,
		Argument = 3,
		Expression = 5,
		Table = 6,
	}
}
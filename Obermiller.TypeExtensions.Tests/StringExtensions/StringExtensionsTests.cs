﻿using System.Text.RegularExpressions;
using Xunit;

namespace Obermiller.TypeExtensions.Tests.StringExtensions;

public partial class StringExtensionsTests
{
	#region CommaJoin

	[Fact]
	public void CommaJoin_Empty_Empty() => Assert.Empty(Empty.CommaJoin());

	[Fact]
	public void CommaJoin_LengthOne_Equal() => Assert.Equal("1", LengthOne.CommaJoin());
	
	[Fact]
	public void CommaJoin_LengthTwo_Joins() => Assert.Equal("1, 2", LengthTwo.CommaJoin());
	
	[Fact]
	public void CommaJoin_LengthThree_Joins() => Assert.Equal("1, 2, 3", LengthThree.CommaJoin());

	#endregion

	#region EqualsIgnoreCase

	[Fact]
	public void EqualsIgnoreCase_Same_True() => Assert.True(ClevelandBrowns.EqualsIgnoreCase(ClevelandBrowns));

	[Fact]
	public void EqualsIgnoreCase_ToLower_True() => Assert.True(ClevelandBrowns.EqualsIgnoreCase(ClevelandBrowns.ToLower()));
	
	[Fact]
	public void EqualsIgnoreCase_ToUpper_True() => Assert.True(ClevelandBrowns.EqualsIgnoreCase(ClevelandBrowns.ToUpper()));
	
	[Fact]
	public void EqualsIgnoreCase_Different_False() => Assert.False(ClevelandBrowns.EqualsIgnoreCase("Baltimore Ravens"));

	#endregion

	#region GenerateRandomAlphaNumeric

	[Fact]
	public void GenerateRandomAlphaNumeric_LengthZero_Empty()
	{
		var underTest = TypeExtensions.StringExtensions.GenerateRandomAlphaNumeric(0);
		
		Assert.Equal(string.Empty, underTest);
	}
	
	[Fact]
	public void GenerateRandomAlphaNumeric_One_EqualLength()
	{
		var underTest = TypeExtensions.StringExtensions.GenerateRandomAlphaNumeric(1);
		
		Assert.Equal(1, underTest.Length);
	}
	
	[Fact]
	public void GenerateRandomAlphaNumeric_OneHundred_EqualLength()
	{
		var underTest = TypeExtensions.StringExtensions.GenerateRandomAlphaNumeric(100);
		
		Assert.Equal(100, underTest.Length);
	}
	
	[Fact]
	public void GenerateRandomAlphaNumeric_IsAlphaNumeric_True()
	{
		var underTest = TypeExtensions.StringExtensions.GenerateRandomAlphaNumeric(100);
		var regex = new Regex("^[A-Z0-9]*$");
		
		Assert.Matches(regex, underTest);
	}

	#endregion
}
using Xunit;

namespace Obermiller.TypeExtensions.Tests.EnumerableExtensions;

public partial class EnumerableExtensionsTests
{
	#region JoinToString

	[Fact]
	public void JoinToString_IntList_Joins()
	{
		var underTest = IntList.JoinToString(", ");
        Assert.Equal(IntListJoined, underTest);
	}
	
	[Fact]
	public void JoinToString_StringList_Joins()
	{
		var underTest = StringList.JoinToString(", ");
		Assert.Equal(StringListJoined, underTest);
	}

	#endregion
	
	#region WithIndex
	
	[Fact]
	public void WithIndex_IntList_PairsIndex()
	{
		var underTest = IntList.WithIndex().ToArray();

		for (var i = 0; i < underTest.Length; i++)
		{
			Assert.Equal(i, underTest[i].index);
		}
	}
    
	[Fact]
	public void WithIndex_StringList_PairsIndex()
	{
		var underTest = StringList.WithIndex().ToArray();

		for (var i = 0; i < underTest.Length; i++)
		{
			Assert.Equal(i, underTest[i].index);
		}
	}
	
	#endregion
}
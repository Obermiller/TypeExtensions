using Xunit;

namespace Obermiller.TypeExtensions.Tests.EnumerableExtensions;

public partial class EnumerableExtensionsTests
{
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
using Xunit;

namespace Obermiller.TypeExtensions.Tests.EnumExtensions;

public partial class EnumExtensionsTests
{
	#region ToFlags

	[Fact]
	public void ToFlags_Default_Empty()
	{
		var result = default(TestEnum).ToFlags();
		Assert.Equal(new List<TestEnum>(), result);
	}

	[Fact]
	public void ToFlags_OneFlag_Single()
	{
		var result = TestEnum.One.ToFlags();
		Assert.Single(result);
	}

	[Fact]
	public void ToFlags_TwoFlags_ContainsBoth()
	{
		var result = (TestEnum.One | TestEnum.Two).ToFlags();
		Assert.Equal(2, result.Count);
		Assert.Contains(TestEnum.One, result);
		Assert.Contains(TestEnum.Two, result);
	}

	#endregion
}
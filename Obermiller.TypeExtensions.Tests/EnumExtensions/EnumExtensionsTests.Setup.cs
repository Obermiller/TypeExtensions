namespace Obermiller.TypeExtensions.Tests.EnumExtensions;

public partial class EnumExtensionsTests
{
	[Flags]
	private enum TestEnum : long
	{
		One = 1 << 0,
		Two = 1 << 1,
		Four = 1 << 2,
		Eight = 1 << 3,
		Sixteen = 1 << 4,
		ThirtyTwo = 1 << 5,
		SixtyFour = 1 << 6
	}
}
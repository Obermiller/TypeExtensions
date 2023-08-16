namespace Obermiller.TypeExtensions.Tests.ClassExtensions;

public partial class ClassExtensionsTests
{
	private class TestClass
	{
		public int Int { get; set; }
		public string String { get; set; } = string.Empty;
		public double Double { get; set; }
		public decimal Decimal { get; set; }
		public bool Bool { get; set; }
		public char Char { get; set; }
	}
	
	private static TestClass BaseTest => new()
	{
		Int = 1,
		String = "Cleveland Browns",
		Double = 1.23,
		Decimal = 4.56m,
		Bool = true,
		Char = 'T'
	};

	private static TestClass CommaTest => new()
	{
		Int = 1,
		String = "Bond, James Bond",
		Double = 1.23,
		Decimal = 4.56m,
		Bool = true,
		Char = ','
	};
	
	private static TestClass SlashTest => new()
	{
		Int = 1,
		String = "and\\or",
		Double = 1.23,
		Decimal = 4.56m,
		Bool = true,
		Char = '\\'
	};
	
	private static TestClass QuotationTest => new()
	{
		Int = 1,
		String = "\"A world without you isn't meant for me\"",
		Double = 1.23,
		Decimal = 4.56m,
		Bool = true,
		Char = '\"'
	};
}
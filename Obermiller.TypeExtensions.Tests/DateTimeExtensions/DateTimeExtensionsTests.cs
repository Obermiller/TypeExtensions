using Xunit;

namespace Obermiller.TypeExtensions.Tests.DateTimeExtensions;

public partial class DateTimeExtensionsTests
{
	#region ToTimeZone

	[Fact]
	public void ToTimeZone_DefaultDate_ToEastern()
	{
		var result = _defaultDate.ToTimeZone(EasternStandardTime);
		
		Assert.Equal(_expectedEasternDateConversion, result);
	}
	
	[Fact]
	public void ToTimeZone_DefaultDate_ToCentral()
	{
		var result = _defaultDate.ToTimeZone(CentralStandardTime);
		
		Assert.Equal(_expectedCentralDateConversion, result);
	}
	
	[Fact]
	public void ToTimeZone_DefaultDate_ToPacific()
	{
		var result = _defaultDate.ToTimeZone(PacificStandardTime);
		
		Assert.Equal(_expectedPacificDateConversion, result);
	}
	
	[Fact]
	public void ToTimeZone_DefaultDaylightDate_ToEastern()
	{
		var result = _defaultDaylightDate.ToTimeZone(EasternStandardTime);
		
		Assert.Equal(_expectedEasternDaylightDateConversion, result);
	}
	
	[Fact]
	public void ToTimeZone_DefaultDaylightDate_ToCentral()
	{
		var result = _defaultDaylightDate.ToTimeZone(CentralStandardTime);
		
		Assert.Equal(_expectedCentralDaylightDateConversion, result);
	}
	
	[Fact]
	public void ToTimeZone_DefaultDaylightDate_ToPacific()
	{
		var result = _defaultDaylightDate.ToTimeZone(PacificStandardTime);
		
		Assert.Equal(_expectedPacificDaylightDateConversion, result);
	}
	
	[Fact]
	public void ToTimeZone_DefaultDateTime_ToEastern()
	{
		var result = _defaultDateTime.ToTimeZone(EasternStandardTime);
		
		Assert.Equal(_expectedEasternDateTimeConversion, result);
	}
	
	[Fact]
	public void ToTimeZone_DefaultDateTime_ToCentral()
	{
		var result = _defaultDateTime.ToTimeZone(CentralStandardTime);
		
		Assert.Equal(_expectedCentralDateTimeConversion, result);
	}
	
	[Fact]
	public void ToTimeZone_DefaultDateTime_ToPacific()
	{
		var result = _defaultDateTime.ToTimeZone(PacificStandardTime);
		
		Assert.Equal(_expectedPacificDateTimeConversion, result);
	}
	
	[Fact]
	public void ToTimeZone_DefaultDaylightDateTime_ToEastern()
	{
		var result = _defaultDaylightDateTime.ToTimeZone(EasternStandardTime);
		
		Assert.Equal(_expectedEasternDaylightDateTimeConversion, result);
	}
	
	[Fact]
	public void ToTimeZone_DefaultDaylightDateTime_ToCentral()
	{
		var result = _defaultDaylightDateTime.ToTimeZone(CentralStandardTime);
		
		Assert.Equal(_expectedCentralDaylightDateTimeConversion, result);
	}
	
	[Fact]
	public void ToTimeZone_DefaultDaylightDateTime_ToPacific()
	{
		var result = _defaultDaylightDateTime.ToTimeZone(PacificStandardTime);
		
		Assert.Equal(_expectedPacificDaylightDateTimeConversion, result);
	}

	#endregion
}
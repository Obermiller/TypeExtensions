namespace Obermiller.TypeExtensions.Tests.DateTimeExtensions;

public partial class DateTimeExtensionsTests
{
	private const string CentralStandardTime = "Central Standard Time";
	private const string EasternStandardTime = "Eastern Standard Time";
	private const string PacificStandardTime = "Pacific Standard Time";

	private readonly DateTime _defaultDate = new(2024, 3, 7);
	private readonly DateTime _defaultDaylightDate = new(2024, 4, 1);
	private readonly DateTime _defaultDateTime = new(2024, 3, 7, 13, 39, 55);
	private readonly DateTime _defaultDaylightDateTime = new(2024, 4, 1, 15, 20, 24);

	private readonly DateTime _expectedEasternDateConversion = new(2024, 3, 6, 19, 0, 0);
	private readonly DateTime _expectedCentralDateConversion = new(2024, 3, 6, 18, 0, 0);
	private readonly DateTime _expectedPacificDateConversion = new(2024, 3, 6, 16, 0, 0);
	private readonly DateTime _expectedEasternDaylightDateConversion = new(2024, 3, 31, 20, 0, 0);
	private readonly DateTime _expectedCentralDaylightDateConversion = new(2024, 3, 31, 19, 0, 0);
	private readonly DateTime _expectedPacificDaylightDateConversion = new(2024, 3, 31, 17, 0, 0);
	private readonly DateTime _expectedEasternDateTimeConversion = new(2024, 3, 7, 8, 39, 55);
	private readonly DateTime _expectedCentralDateTimeConversion = new(2024, 3, 7, 7, 39, 55);
	private readonly DateTime _expectedPacificDateTimeConversion = new(2024, 3, 7, 5, 39, 55);
	private readonly DateTime _expectedEasternDaylightDateTimeConversion = new(2024, 4, 1, 11, 20, 24);
	private readonly DateTime _expectedCentralDaylightDateTimeConversion = new(2024, 4, 1, 10, 20, 24);
	private readonly DateTime _expectedPacificDaylightDateTimeConversion = new(2024, 4, 1, 8, 20, 24);
}
public static class ValidationHelper
{
    public static bool ValidateSerialNumber(string serialNumber)
    {
        return !string.IsNullOrWhiteSpace(serialNumber);
    }
}

namespace API.Extensions;

public static class DateTimeExtensions
{
    public static int CalculateAge(this DateTime dob)
    {
        var today = DateTime.Today;
        return today.Year - dob.Year;
    }
    
}
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BusinessObjects
{
    public class DateOnlyConverterExtensions: ValueConverter<DateOnly, DateTime>
    {
        public DateOnlyConverterExtensions()
       : base(dateOnly => dateOnly.ToDateTime(TimeOnly.MinValue),
           dateTime => DateOnly.FromDateTime(dateTime))
        { }
    }
}

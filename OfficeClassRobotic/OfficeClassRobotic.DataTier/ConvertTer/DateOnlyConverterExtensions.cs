using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace OfficeClassRobotic.DataTier
{
    public class DateOnlyConverterExtensions: ValueConverter<DateOnly, DateTime>
    {
        public DateOnlyConverterExtensions()
       : base(dateOnly => dateOnly.ToDateTime(TimeOnly.MinValue),
           dateTime => DateOnly.FromDateTime(dateTime))
        { }
    }
}

using AutoMapper;
using Core.Helpers;
using Humanizer;

namespace WebApi.Mapping;

public class SharedProfile: Profile
{
    public SharedProfile()
    {
        CreateMap<DateTime, string>()
            .ConvertUsing(date => date.ToString("d"));
        CreateMap<DateTime, DateTime>()
            .ConvertUsing(date => date.SetKindUtc());

        CreateMap<DateTime?, string>()
            .ConvertUsing(date => date.HasValue ? date.Value.ToString("d") : null);

        CreateMap<DateTimeOffset, string>()
            .ConvertUsing(date => date.ToString("d"));

        CreateMap<Enum, string>()
            .IncludeAllDerived()
            .ConvertUsing(@enum => @enum.ToString().Humanize()); // Enum.Humanize() crashes
    }
}
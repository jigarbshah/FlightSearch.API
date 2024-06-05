//Associated with flightresult
namespace FlightSearch.Domain.ValueObjects;

public record Slices
{

    public int Current { get; set; } = default!;
    public int Total { get; set; } = default!;

    private Slices(int current, int total)
    {
        Current = current;
        Total = total;
    }

    public static Slices Of(int current, int total)
    {

        return new Slices(current, total);
    }

}

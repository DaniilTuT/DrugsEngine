using ISO3166;

namespace Domain.Validators;

public static class CountryCodes
{
    public static HashSet<string> AllCountryCodes = new(Country.List.Select(c => c.TwoLetterCode));
}
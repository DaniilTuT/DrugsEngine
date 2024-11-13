namespace Domain.Validators;

public static class ValidationMessage
{
    public static string NotNull = "{PropertyName} не может быть пустым.";
    public static string NotEmpty = "{PropertyName} не может быть пустым.";
    public static string WrongLength = "{PropertyName} должен содержать от {MinLength} до {MaxLength} символов.";
    public static string WrongExactLength = "{PropertyName} должен быть ровно {ExactLength} символов.";
    public static string WrongMatchCountryCode = "{PropertyName} должен состоять из 2 заглавных латинских букв.";
    public static string WrongMatchManufacturer = "{PropertyName} должен содержать только буквы, пробелы и дефисы.";
    public static string WrongMatchName = "{PropertyName} должен содержать только буквы и пробелы.";
    public static string CountryCodeInvalid = "{PropertyName} содержит недействительный код страны.";
    public static string InvalidCost = "{PropertyName} должен быть положительным числом с не более чем двумя знаками после запятой.";
    public static string IntMustBeGreaterThanZero = "{PropertyName} должен быть положительным целым числом.";
    public static string AlreadyExist = "{PropertyName} уже существует в пределах сети.";
    public static string InexesistingNetwork = "{PropertyName} не существует такой сети.";
    public static string OutOfRangeCount = "{PropertyName} должен быть целым числом от 0 до 10000.";
}
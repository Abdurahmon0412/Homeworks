namespace N23_HT24.Services;

public class RegistrationService
{
    //RegistrationService dan foydalaning
    //unda quyidagi methodlar bo'lsin 

    //- Register ( firstName, lastName, emailAddress, password ) -UserService orqali userni UserCredentialsService
    //orqali credentialni qo'shsin, hammasi muvaffaqqiyatli bo'lsa true, bo'lmasa false qaytarsin


    private readonly IUserService _userService;
    private readonly IUserCredentialsService _credentialsService;

    public RegistrationService(IUserService userService, IUserCredentialsService credentialsService)
    {
        _userService = userService;
        _credentialsService = credentialsService;
    }

    public bool Register(string firstName, string lastName, string emailAddress, string password)
    {
        try
        {
            var user = _userService.Add(firstName, lastName, emailAddress);
            _credentialsService.Add(user.Id, password);
            return true;
        }
        catch
        {
            return false;
        }
    }
}
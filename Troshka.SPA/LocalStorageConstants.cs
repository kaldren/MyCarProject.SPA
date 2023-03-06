namespace Troshka.SPA;
public class LocalStorageConstants
{
    // For currently logged in user
    public const string Troshka = nameof(Troshka);

    public const string TroshkaCurrentUser = "Troshka_CurrentUser";

    public const string TroshkaCurrentUserLoggedIn = $"{TroshkaCurrentUser}_IsLoggedIn";
    public const string TroshkaCurrentUserProfile = $"{TroshkaCurrentUser}_UserProfile";
    public const string TroshkaCurrentUserComments = $"{TroshkaCurrentUser}_Comments";
    public const string TroshkaCurrentUserCommented = $"{TroshkaCurrentUser}_Commented";

    // Some user
    public const string TroshkaUser = "Troshka_UserId";
    public const string TroshkaUserComments = $"{TroshkaUser}_Comments";


    // General
    public const string TroshkaGeneral = "Troshka_General";

    public const string Occupations = $"{TroshkaGeneral}_Occupations";
    public const string Countries = $"{TroshkaGeneral}_Countries";

    // Vehicles
    public const string Troshka_VehicleSearch_Categories = $"{nameof(Troshka_VehicleSearch_Categories)}";
    public const string Troshka_VehicleSearch_Regions = $"{nameof(Troshka_VehicleSearch_Regions)}";
}
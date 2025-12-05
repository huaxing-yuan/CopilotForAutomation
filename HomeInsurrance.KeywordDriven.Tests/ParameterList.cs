namespace HomeInsurrance.KeywordDriven.Tests
{
    /// <summary>
    /// Liste des paramètres utilisés dans les scénarios Keyword-Driven.
    /// </summary>
    public static class ParameterList
    {
        ///<Summary>URL de l'application à tester</Summary>
        public static string URL_RECETTE { get; } = "URL_RECETTE";
        ///<Summary>Identifiant utilisateur</Summary>
        public static string User { get; } = "User";
        ///<Summary>Mot de passe chiffré</Summary>
        public static string EncPassword { get; } = "EncPassword";
        ///<Summary>Identifiant prospect</Summary>
        public static string ProspectId { get; } = "ProspectId";

        // Home Location
        public static string StreetNumber { get; } = "StreetNumber";
        public static string StreetName { get; } = "StreetName";
        public static string City { get; } = "City";
        public static string PostCode { get; } = "PostCode";
        public static string Region { get; } = "Region";
        public static string Country { get; } = "Country";

        // Home Details
        public static string HomeType { get; } = "HomeType"; // apartment/house

        // Maison
        public static string HouseFloors { get; } = "HouseFloors";
        public static string SurfaceBackyard { get; } = "SurfaceBackyard";
        public static string Pool { get; } = "Pool"; // yes/no

        // Appartement
        public static string TotalFloors { get; } = "TotalFloors";
        public static string MyFloors { get; } = "MyFloors";
        public static string Elevator { get; } = "Elevator"; // yes/no

        // Commun
        public static string Rooms { get; } = "Rooms";
        public static string Surface { get; } = "Surface";
    }
}
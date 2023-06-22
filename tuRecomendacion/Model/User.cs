namespace tuRecomendacion.Model
{
    public class User
    {
        public string Id { get; set; }    // The user's unique identifier
        public string Name { get; set; }  // The user's name
                                          // ... add more properties as needed ...


        public static User Default
        => new User() { Id = "0", Name = "Test" };
    }


}


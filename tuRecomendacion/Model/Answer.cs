namespace tuRecomendacion.Model
{
    public class Answer
    {
        public string QuestionId { get; set; } // The ID of the question this answer is for
        public string UserId { get; set; }     // The ID of the user who gave this answer
        public string Choice { get; set; }     // The user's chosen answer
                                               // ... add more properties as needed ...
    }


}


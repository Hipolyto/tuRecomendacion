using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using tuRecomendacion.Interfaces;
using tuRecomendacion.Model;

namespace tuRecomendacion.Services
{
    public class MockQuestionService : IQuestionService
    {
        public Task<List<Question>> GetQuestionsAsync()
        {
            // Create a list of mock questions
            var questions = new List<Question>
        {
            new Question
            {
                Id = "1",
                Text = "¿Cuál es tu edad?",
                Choices = new List<QuestionOption>
                {
                    new QuestionOption("Menor de 18"),
                    new QuestionOption("18-30"),
                   new QuestionOption( "31-50"),
                    new QuestionOption("51 o más")
                }
            },
            new Question
            {
                Id = "2",
                Text = "¿Con quién vas? ¿Pareja o amigos?",
                Choices = new List<QuestionOption>
                {
                   new QuestionOption( "Pareja"),
                   new QuestionOption( "Amigos")
                }
            },
            new Question
            {
                Id = "3",
                Text = "¿Qué prefieres? ¿Día, noche o tarde?",
                Choices = new List<QuestionOption>
                {
                   new QuestionOption( "Día"),
                  new QuestionOption(  "Tarde"),
                   new QuestionOption( "Noche")
                }
            },
            new Question
            {
                Id = "4",
                Text = "¿Qué estilo prefieres? ¿Formal o casual?",
                Choices = new List<QuestionOption>
                {
                   new QuestionOption( "Formal"),
                   new QuestionOption( "Casual")
                }
            }
        };

            // Return the list of questions as a Task
            return Task.FromResult(questions);
        }
    }

}


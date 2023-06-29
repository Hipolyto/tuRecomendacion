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
                    Text = "What is your age?",
                    Choices = new List<QuestionOption>
                    {
                        new QuestionOption("Under 18"),
                        new QuestionOption("18-30"),
                        new QuestionOption("31-50"),
                        new QuestionOption("51 or older")
                    }
                },
                new Question
                {
                    Id = "2",
                    Text = "Who are you going with? Partner or friends?",
                    Choices = new List<QuestionOption>
                    {
                        new QuestionOption("Partner"),
                        new QuestionOption("Friends")
                    }
                },
                new Question
                {
                    Id = "3",
                    Text = "What do you prefer? Day, evening, or night?",
                    Choices = new List<QuestionOption>
                    {
                        new QuestionOption("Day"),
                        new QuestionOption("Evening"),
                        new QuestionOption("Night")
                    }
                },
                new Question
                {
                    Id = "4",
                    Text = "What style do you prefer? Formal or casual?",
                    Choices = new List<QuestionOption>
                    {
                        new QuestionOption("Formal"),
                        new QuestionOption("Casual")
                    }
                }
            };

            // Return the list of questions as a Task
            return Task.FromResult(questions);
        }
    }
}

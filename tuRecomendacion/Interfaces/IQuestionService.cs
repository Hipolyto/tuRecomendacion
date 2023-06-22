using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using tuRecomendacion.Model;

namespace tuRecomendacion.Interfaces
{
    public interface IQuestionService
    {
        Task<List<Question>> GetQuestionsAsync();
    }

}


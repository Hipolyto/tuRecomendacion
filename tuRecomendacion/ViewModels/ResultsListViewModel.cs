using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenAI;
using OpenAI.Managers;
using OpenAI.ObjectModels;
using OpenAI.ObjectModels.RequestModels;
using tuRecomendacion.Model;

namespace tuRecomendacion.ViewModels
{
    [QueryProperty(nameof(QuestionsList), "QuestionsList")]
    public class ResultsListViewModel : BaseViewModel
    {
        public List<Question> QuestionsList { get; set; }

        public ResultsListViewModel()
        {
        }

        public override void OnAppearing()
        {
            base.OnAppearing();
            LoadData();
        }

        private async void LoadData()
        {
            var openAiService = new OpenAIService(new OpenAiOptions()
            {
                ApiKey = App.ApiKey
            });

            var request = new ChatCompletionCreateRequest
            {
                Messages = new List<ChatMessage>
    {
        ChatMessage.FromSystem("Eres un experto en actividades regreativas, quiero todas las respuesta en formato json"),
        ChatMessage.FromUser("Soy una persona masculina de entre 30 - 40 años, recomiendame actividades en la Paz, baja california sur, para entre las 8pm y 12 am, actividades casuales por favor, voy con mi esposa"),
       // ChatMessage.FromAssistant("The Los Angeles Dodgers won the World Series in 2020."),
       ChatMessage.FromUser("si la respeusta es ir a un lugar especifico como un restaurante necesito el nombre del lugar, alguna recomendacion de platillo y ubicacion en gps"),
       ChatMessage.FromUser("si la respeusta es una actividad, necesito q me recomeindes tipo de vestimenta"),
       // ChatMessage.FromUser("quiero la respuesta en formato json"),
        ChatMessage.FromUser("necestio al menos 10 actividades")
    },
                Model = Models.Gpt_4
                //MaxTokens = 100//optional
            };

            var completionResult = await openAiService.ChatCompletion.CreateCompletion(request);
            //var completionResult2 = openAiService.ChatCompletion.CreateCompletionAsStream(request);
            var str = string.Empty;


          

            if (completionResult.Successful)
             {
                Console.WriteLine(completionResult.Choices.First().Message.Content);
                str = completionResult.Choices.First().Message.Content;
            }
            /*
            
            await foreach (var completion in completionResult)
            {
                if (completion.Successful)
                {
                    str += completion.Choices.FirstOrDefault().Message.Content;
                    Console.Write(completion.Choices.FirstOrDefault().Message.Content);
                }
                else
                {
                    if (completion.Error == null)
                    {
                        throw new Exception("Unknown Error");
                    }

                    Console.WriteLine($"{completion.Error.Code}: {completion.Error.Message}");
                }
            }
            */
            Console.Write(str);
        }

        public List<Question> Questions { get; }
    }
}

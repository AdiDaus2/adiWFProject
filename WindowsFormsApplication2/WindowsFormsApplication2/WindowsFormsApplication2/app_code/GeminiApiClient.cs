//using System;
//using System.Linq;
//using System.Net.Http;
//using System.Text;
//using Newtonsoft.Json;
//using System.Threading.Tasks;
///// <summary>
///// המחלקה המרכזית שמטפלת בתקשורת מול ה-API של ג'מיני.
///// </summary>
///// 
//namespace WindowsFormsApplication2
//{
//    public class GeminiApiClient
//    {
//        // מומלץ ליצור מופע אחד של HttpClient ולהשתמש בו שוב ושוב.
//        private static readonly HttpClient client = new HttpClient();
//        private readonly string _apiKey;
//        private readonly string _model;

//        public GeminiApiClient(string apiKey, string model = "gemini-1.5-flash-latest")
//        {
//            _apiKey = apiKey;
//            _model = model;
//        }

//        /// <summary>
//        /// שולח בקשת טקסט ל-API ומחזיר את התשובה.
//        /// </summary>
//        /// <param name="prompt">הטקסט לשליחה למודל.</param>
//        /// <returns>הטקסט שהמודל יצר.</returns>
//        public async Task<string> GenerateContentAsync(string prompt)
//        {
//            var url = $"https://generativelanguage.googleapis.com/v1beta/models/{_model}:generateContent?key={_apiKey}";

//            var requestBody = new GeminiRequest
//            {
//                Contents = new[]
//                {
//                new Content
//                {
//                    Parts = new[] { new Part { Text = prompt } }
//                }
//            }
//            };

//            var jsonContent = JsonConvert.SerializeObject(requestBody);
//            var httpContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");

//            var response = await client.PostAsync(url, httpContent);

//            if (response.IsSuccessStatusCode)
//            {
//                var jsonResponse = await response.Content.ReadAsStringAsync();
//             //   var geminiResponse = JsonSerializer.Deserialize<GeminiResponse>(jsonResponse);

//                // חילוץ הטקסט מהתשובה
//              //  string responseText = geminiResponse?.Candidates?.FirstOrDefault()?.Content?.Parts?.FirstOrDefault()?.Text;
//             //   return responseText ?? "No content generated.";
//            }
//            else
//            {
//                var errorContent = await response.Content.ReadAsStringAsync();
//                throw new HttpRequestException($"API call failed with status {response.StatusCode}: {errorContent}");
//            }
//        }
//    }


//    // --- מודלי נתונים עבור שליחה וקבלה של JSON ---

//    // משמש לגוף הבקשה שנשלחת
//    public class GeminiRequest
//    {
//      //  [JsonPropertyName("contents")]
//        public Content[] Contents { get; set; }
//    }

//    //// משמש גם בבקשה וגם בתשובה
//    public class Content
//    {
//     //   [JsonPropertyName("parts")]
//        public Part[] Parts { get; set; }

//      //  [JsonPropertyName("role")]
//        public string Role { get; set; } // קיים רק בתשובה
//    }

//    public class Part
//    {
//     //   [JsonPropertyName("text")]
//        public string Text { get; set; }
//    }

//    //// משמש לפענוח התשובה שמגיעה מהשרת
//    public class GeminiResponse
//    {
//       // [JsonPropertyName("candidates")]
//        public Candidate[] Candidates { get; set; }
//    }

//    public class Candidate
//    {
//      //  [JsonPropertyName("content")]
//        public Content Content { get; set; }
//    }
//}

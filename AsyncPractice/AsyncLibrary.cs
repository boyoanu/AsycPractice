using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AsyncPractice
{
    class AsyncLibrary
    {

        public async Task<int> AddNums1to20Async()
        {
            int sum = 0;

            for (int i = 1; i <= 20; i++)
            {
                // Add the current counter value to sum
                sum += i;

                // Print the current value of the counter
                Console.WriteLine(i);

                // Delay for 2 seconds
                await Task.Delay(2000);
            }
            return sum;
        }


        public async Task<int> GetCharacterCountAsync()
        {
            // Get the file path stored in a string variable
            string filePath = @"C:\Users\HP\Documents\DummyText.txt";

            // Open a 'using' block that creates and uses a StreamReader object
            string fileContent;

            using (StreamReader reader = new StreamReader(filePath))
            {
                // Read all the content of the file into a string variable
                Task<string> contentTask = reader.ReadToEndAsync();
                fileContent = await contentTask;
            }

            // Get the length of the string storing the file content 
            int count = fileContent.Length;
            return count;
        }


        public async Task DisplayWebpageContentAsync(string webAddress) {

            // Create an HttpClient object
            HttpClient webClient = new HttpClient
            {
                // Set the base address as the webAddress argument
                BaseAddress = new Uri(webAddress)
            };

            // Make the web request
            Task<HttpResponseMessage> responseMessageTask = webClient.SendAsync(new HttpRequestMessage { Method = HttpMethod.Get });

            // Read the response as text/string and store it in a variable
            HttpResponseMessage responseMessage = await responseMessageTask;

            string textContent = await responseMessage.Content.ReadAsStringAsync();

            // Display the string content on the console.
            Console.WriteLine($"TEXT FROM {webAddress} READS AS FOLLOWS:");
            Console.WriteLine(textContent);
        }
    }
}

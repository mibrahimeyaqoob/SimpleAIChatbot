using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace SimpleAIChatbot
{
    public partial class SimpleAIChatbot : Form
    {
        private async Task<string> GetA4FResponse(string userMessage, string selectedModel)
        {
            string apiKey = "ddc-a4f-84ddbd64e86349328d9263ec52973fa2"; // **IMPORTANT: Store securely in a real application!**
            string apiUrl = "https://api.a4f.co/v1/chat/completions";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var requestBody = new
                {
                    model = selectedModel,
                    messages = new[]
                    {
                new { role = "user", content = userMessage }
            }
                };

                string jsonBody = JsonSerializer.Serialize(requestBody);
                var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                try
                {
                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);
                    response.EnsureSuccessStatusCode(); // Throw exception for non-success status codes

                    string responseBody = await response.Content.ReadAsStringAsync();
                    JsonDocument jsonResponse = JsonDocument.Parse(responseBody);
                    string botMessage = jsonResponse.RootElement
                        .GetProperty("choices")[0]
                        .GetProperty("message")
                        .GetProperty("content")
                        .GetString();

                    return botMessage;
                }
                catch (HttpRequestException ex)
                {
                    return $"Error: API request failed: {ex.Message}";
                }
                catch (JsonException ex)
                {
                    return $"Error: JSON parsing failed: {ex.Message}";
                }
                catch (Exception ex)
                {
                    return $"Error: An unexpected error occurred: {ex.Message}";
                }
            }
        }
        public SimpleAIChatbot()
        {
            InitializeComponent();
        }

        private void modelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void sendButton_Click(object sender, EventArgs e)
        {
            string userMessage = userInputTextBox.Text;
            string selectedModel = modelComboBox.SelectedItem as string;
            //Get selected Model, modelComboBox.SelectedItem is the Object so do (cast) to String
            if (!string.IsNullOrWhiteSpace(userMessage) && !string.IsNullOrEmpty(selectedModel)) // Check message and model selected
            {
                // Append user message to conversation history
                conversationHistoryRichTextBox.AppendText("You: " + userMessage + Environment.NewLine);
                // Clear the input text box
                userInputTextBox.Clear();
                try
                {
                    // Call the A4F API to get the bot's response
                    string botMessage = await GetA4FResponse(userMessage, selectedModel);
                    // Append the bot's message to the conversation history
                    conversationHistoryRichTextBox.AppendText("Bot: " + botMessage + Environment.NewLine);
                }
                catch (Exception ex)
                {
                    // Handle exceptions (display error message in UI)
                    conversationHistoryRichTextBox.AppendText($"Error: {ex.Message}" + Environment.NewLine);
                }
                // Scroll the RichTextBox to the end
                conversationHistoryRichTextBox.SelectionStart = conversationHistoryRichTextBox.Text.Length;
                conversationHistoryRichTextBox.ScrollToCaret();
            }
            else
            {
                MessageBox.Show("Please enter a message and select a model.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);// Info Message to user
            }
        }

        private void conversationHistoryRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void userInputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sendButton_Click(sender, e);
                e.SuppressKeyPress = true; // Prevents the "ding" sound
            }
        }
    }
}
// Thanks For wacthing don't forget to like subscribe our channel. GOOD BYE!
# Simple AI Chatbot

A simple AI chatbot application built using C# and Windows Forms, leveraging the A4F API for AI-powered responses.

## Description

This application provides a user-friendly interface for interacting with an AI chatbot. It allows users to send text messages, receive intelligent responses from the A4F API, switch between different AI models (available on the A4F free tier), and maintains conversation history for context. The application also includes error handling and basic rate limiting to ensure a smooth user experience.

## Technologies Used

*   C#
*   .NET 6
*   Windows Forms
*   A4F API (`https://api.a4f.co/v1/chat/completions`)
*   System.Net.Http (for making API requests)
*   System.Text.Json (for parsing JSON responses)

## Features

*   Text-based chat interface
*   AI-powered responses powered by A4F API
*   Model selection (supports multiple models from the A4F free tier)
*   Conversation history for context-aware interactions
*   Error handling (displays informative error messages)
*   Basic rate limiting to respect A4F API limits
*   Enter key support for sending messages

## Instructions for Running

1.  Clone the repository: `git clone https://github.com/mibrahimeyaqoob/SimpleAIChatbot.git` (Replace with the actual URL)
2.  Open the `SimpleAIChatbot.sln` solution file in Visual Studio.
3.  Replace `YOUR_API_KEY` in `Form1.cs` with your A4F API key.
4.  Build and run the application.

## Contact

If you have any questions or suggestions, feel free to open an issue or pull request.

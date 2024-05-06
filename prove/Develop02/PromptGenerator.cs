using System;
using System.Collections.Generic;
using System.Security.Cryptography;

public class PromptGenerator
{
        public List<string> _prompts = new List<string>
        {
            "Tell me something you did nice for someone today:",
            "What was the yummiest food you ate today?",
            "Tell me about a goal you are working on:",
            "What is one thing you love about yourself?",
            "Tell me something that made you smile today:",
        };


    public string GetRandomPrompt()
        { // get random index value and lookup the string in _prompts
        Random rnd = new Random();
        string randomPrompt = "";
        int r = rnd.Next(_prompts.Count);
        randomPrompt = _prompts[r];

        return randomPrompt;
        }
}
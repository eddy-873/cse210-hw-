using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompt = new List<string>
    {
        "who was the most interesting person I interacted with Today?",
        "What was the best part of my day?",
        "How did see the hand of the Lord in my Life Today?",
        "What was the strongest emotion i feel today?",
        "If I had one thing I could over today, what would it be?",
        "What is one thing I learned today?"

    };
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompt.Count);
        return _prompt[index];
    }
}

public class PromptGenerator
{
    public string Generate()
    {
        string[] prompts = new string[]
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "What accomplishment made you proud and how did it make you feel?",
            "List three things you are grateful for today and describe why each one is important to you.",
            "What challenge did you face today, how did you handle it, and what did you learn?",
            "Based on today, what steps did you take toward your long-term goals? What will you do tomorrow?",
            "Who made a significant impact on your life today and how did they influence you?"
        };

        Random random = new Random();
        int index = random.Next(0, prompts.Length);
        return prompts[index];
    }
}

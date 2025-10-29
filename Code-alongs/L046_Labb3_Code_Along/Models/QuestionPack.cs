using System;
using System.Collections.Generic;
namespace L046_Labb3_Code_Along.Models;

internal enum Difficulty { Easy, Medium, Hard }
internal class QuestionPack
{
    public QuestionPack(string name, Difficulty difficulty = Difficulty.Medium, int timeLimitInSeconds = 30)
    {
        Name = name;
        Difficulty = difficulty;
        TimeLimitInSeconds = timeLimitInSeconds;
        Questions = new List<Question>();
    }

    public string Name { get; set; }
    public Difficulty Difficulty { get; set; }
    public int TimeLimitInSeconds { get; set; }

    public List<Question> Questions { get; set; }
}

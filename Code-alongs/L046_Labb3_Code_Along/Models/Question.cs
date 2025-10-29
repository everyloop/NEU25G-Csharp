namespace L046_Labb3_Code_Along.Models;

internal class Question
{
    public Question(string query, string correctAnswer,
        string incorrectAnswer1, string incorrectAnswer2, string incorrectAnswer3)
    {
        Query = query;
        CorrectAnswer = correctAnswer;
        IncorrectAnswers = [incorrectAnswer1, incorrectAnswer2, incorrectAnswer3];
    }

    public string Query { get; set; }

    public string CorrectAnswer { get; set; }

    public string[] IncorrectAnswers { get; set; }

}

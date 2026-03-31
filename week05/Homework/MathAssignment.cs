using System;
using System.Collections.Generic;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textbookSection, string problem)
        : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problem;
    }

    public string GetHomeworkList()
    {
        return $"Section: {_textbookSection} Problem: {_problems}";
    }
}

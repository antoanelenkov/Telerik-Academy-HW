using System;

public class ExamResult
{
    public int Grade { get; private set; }
    public int MinGrade { get; private set; }
    public int MaxGrade { get; private set; }
    public string Comments { get; private set; }

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        // It is better to validate in properties, but this is not purpose of the homework.
        if (grade < 0)
        {
            throw new IndexOutOfRangeException("Grade must be non-negative");
        }
        if (minGrade < 0)
        {
            throw new IndexOutOfRangeException("minGrade must be non-negative");
        }
        if (maxGrade <= minGrade)
        {
            throw new IndexOutOfRangeException("maxGrade must be greater than minGrade");
        }
        if (comments == null || comments == "")
        {
            throw new ArgumentNullException("comments must not be null or empty");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }
}

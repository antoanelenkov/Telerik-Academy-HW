using System;

public class CSharpExam : Exam
{
    private const int MaxResult = 100;

    private int score = 0;

    public CSharpExam(int score)
    {
        this.Score = score;
    }

    public int Score
    {
        get
        {
            return this.score;
        }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Score must be non-negative");
            }

            this.score = value;
        }
    }

    public override ExamResult Check()
    {
        if (Score < 0 || Score > MaxResult)
        {
            throw new ArgumentOutOfRangeException("Score must be non-negative and less than " + MaxResult);
        }
        else
        {
            return new ExamResult(this.Score, 0, MaxResult, "Exam results calculated by score.");
        }
    }
}

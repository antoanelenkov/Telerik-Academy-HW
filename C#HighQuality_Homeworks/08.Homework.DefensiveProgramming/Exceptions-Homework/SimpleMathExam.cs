using System;

public class SimpleMathExam : Exam
{
    private const int MaxNumberOfSolvedProblems = 2;

    public int ProblemsSolved { get; private set; }

    public SimpleMathExam(int problemsSolved)
    {
        // It is better to validate in properties, but this is not purpose of the homework.
        if (problemsSolved < 0)
        {
            throw new ArgumentOutOfRangeException("problemSolved must be non-negative");
        }
        if (problemsSolved > MaxNumberOfSolvedProblems)
        {
            throw new ArgumentOutOfRangeException("problemSolved must be greater than " + MaxNumberOfSolvedProblems);
        }

        this.ProblemsSolved = problemsSolved;
    }

    public override ExamResult Check()
    {
        if (ProblemsSolved == 0)
        {
            return new ExamResult(2, 2, 6, "Bad result: nothing done.");
        }
        else if (ProblemsSolved == 1)
        {
            return new ExamResult(4, 2, 6, "Average result: nothing done.");
        }
        else if (ProblemsSolved == 2)
        {
            return new ExamResult(6, 2, 6, "Average result: nothing done.");
        }

        // Practically this code will never execute because of the constant
        throw new ArgumentOutOfRangeException("The solved problems must be between 0 and " + MaxNumberOfSolvedProblems);
    }
}

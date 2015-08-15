namespace MatrixUI.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using MatrixTask;

    [TestClass]
    public class ConsoleUITests
    {
        ConsoleUI testConsole = new ConsoleUI();

        private string matrix1;
        private string matrix2;
        private string matrix3;

        [TestInitialize]
        public void InitilizeResultsToCompare()
        {
            this.matrix1 = "  1" + Environment.NewLine;

            this.matrix2 = "  1  4"
                + Environment.NewLine
                + "  3  2"
                + Environment.NewLine;

            this.matrix3 = "  1  7  8"
                + Environment.NewLine
                + "  6  2  9"
                + Environment.NewLine
                + "  5  4  3"
                + Environment.NewLine;
        }


        [TestMethod]
        public void Write_WithSize1()
        {
            RotatingMatrixSolver testSolver = new RotatingMatrixSolver(1);

            var expected = this.matrix1;
            var actual = testConsole.Write(testSolver.Field);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Write_WithSize2()
        {
            RotatingMatrixSolver testSolver = new RotatingMatrixSolver(2);

            var expected = this.matrix2;
            var actual = testConsole.Write(testSolver.Field);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Write_WithSize3()
        {
            RotatingMatrixSolver testSolver = new RotatingMatrixSolver(3);

            var expected = this.matrix3;
            var actual = testConsole.Write(testSolver.Field);

            Assert.AreEqual(expected, actual);
        }
    }
}

namespace MatrixTask.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class RotatingMatrixSolverTests
    {
        private int[,] matrix1;
        private int[,] matrix2;
        private int[,] matrix3;
        private int[,] matrix4;
        private int[,] matrix5;

        [TestInitialize]
        public void InitilizeResultsToCompare()
        {
            this.matrix1 = new int[,] { { 1 } };

            this.matrix2 = new int[,] {{1, 4},
                                  {3, 2}};

            this.matrix3 = new int[,] {{1, 7, 8},
                                  {6, 2, 9},
                                  {5, 4, 3}};

            this.matrix4 = new int[,] {{1,10, 11, 12},
                                  {9, 2, 15, 13},
                                  {8, 16, 3, 14},
                                  {7, 6, 5, 4}};

            this.matrix5 = new int[,] {{1,13,14,15,16},
                                  {12,2,21,22,17},
                                  {11,23,3,20,18},
                                  {10,25,24,4,19},
                                  {9,8,7,6,5}};
        }

        [TestMethod]
        public void RotatingMatrixSolver_WithSizeOf1()
        {
            RotatingMatrixSolver testSolver= new RotatingMatrixSolver(1);

            Assert.IsTrue(this.CompareMatrixes(testSolver.Field, this.matrix1));
        }

        [TestMethod]
        public void RotatingMatrixSolver_WithSizeOf2()
        {
            RotatingMatrixSolver testSolver = new RotatingMatrixSolver(2);

            Assert.IsTrue(this.CompareMatrixes(testSolver.Field, this.matrix2));
        }

        [TestMethod]
        public void RotatingMatrixSolver_WithSizeOf3()
        {
            RotatingMatrixSolver testSolver = new RotatingMatrixSolver(3);

            Assert.IsTrue(this.CompareMatrixes(testSolver.Field, this.matrix3));
        }

        [TestMethod]
        public void RotatingMatrixSolver_WithSizeOf4()
        {
            RotatingMatrixSolver testSolver = new RotatingMatrixSolver(4);

            Assert.IsTrue(this.CompareMatrixes(testSolver.Field, this.matrix4));
        }

        [TestMethod]
        public void RotatingMatrixSolver_WithSizeOf5()
        {
            RotatingMatrixSolver testSolver = new RotatingMatrixSolver(5);

            Assert.IsTrue(this.CompareMatrixes(testSolver.Field, this.matrix5));
        }

        private bool CompareMatrixes(int[,] first, int[,] second)
        {
            if(first.GetLength(0)!=second.GetLength(0)
                || first.GetLength(1) != second.GetLength(1))
            {
                return false;
            }

            for (int i = 0; i < first.GetLength(0); i++)
            {
                for (int j = 0; j < first.GetLength(1); j++)
                {
                    if (first[i, j] != second[i, j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}

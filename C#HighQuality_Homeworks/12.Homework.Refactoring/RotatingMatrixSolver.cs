namespace MatrixTask
{
    using System;
    using System.Text;

    public class RotatingMatrixSolver
    {
        private readonly int size;
        private readonly int[,] field;

        private int currentRow = 0;
        private int currentCol = 0;
        private int dx = 1;
        private int dy = 1;


        public RotatingMatrixSolver(int size)
        {
            this.field = new int[size, size];
            this.size = size;

            this.Fill();
        }

        public int[,] Field
        {
            get
            {
                return this.field;
            }
        }

        public void Fill()
        {
            int currentNumber = 1;

            for (int i = 0; i < this.size * this.size; i++)
            {
                this.field[currentRow, currentCol] = currentNumber;

                if (this.NextCellIsFree(currentRow, currentCol))
                {
                    while ((currentRow + this.dx >= this.size
                   || currentRow + this.dx < 0
                   || currentCol + dy >= this.size
                   || currentCol + dy < 0
                   || this.field[currentRow + this.dx, currentCol + dy] != 0))
                    {
                        this.ChangeDirection(this.dx, this.dy);
                    }

                    currentRow += this.dx;
                    currentCol += this.dy;
                }
                else
                {
                    this.FindFreeCell(currentRow, currentCol);

                    this.dx = 1;
                    this.dy = 1;
                }

                currentNumber++;
            }
        }

        public bool NextCellIsFree(int row, int col)
        {
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };
            int numberOfDirections = dirX.Length;

            for (int i = 0; i < numberOfDirections; i++)
            {
                if (row + dirX[i] >= this.field.GetLength(0) || row + dirX[i] < 0)
                {
                    dirX[i] = 0;
                }

                if (col + dirY[i] >= this.field.GetLength(0) || col + dirY[i] < 0)
                {
                    dirY[i] = 0;
                }
            }

            for (int i = 0; i < numberOfDirections; i++)
            {
                if (this.field[row + dirX[i], col + dirY[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public void FindFreeCell(int row, int col)
        {
            for (int i = 0; i < this.field.GetLength(0); i++)
            {
                for (int j = 0; j < this.field.GetLength(0); j++)
                {
                    if (field[i, j] == 0)
                    {
                        this.currentRow = i; this.currentCol = j;
                        return;
                    }
                }
            }
        }

        private void ChangeDirection(int dx,int dy)
        {
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };
            int numberOfDirections = dirX.Length;

            int currentDir = 0;
            for (int i = 0; i < numberOfDirections; i++)
            {
                if (dirX[i] == this.dx && dirY[i] == this.dy)
                {
                    currentDir = i;
                    break;
                }
            }

            if (currentDir == numberOfDirections-1)
            {
                this.dx = dirX[0];
                this.dy = dirY[0];
                return;
            }

            this.dx = dirX[currentDir + 1];
            this.dy = dirY[currentDir + 1];
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            for (int i = 0; i < this.size; i++)
            {
                for (int j = 0; j < this.size; j++)
                {
                    sb.AppendFormat("{0,3}", this.field[i, j]);
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}

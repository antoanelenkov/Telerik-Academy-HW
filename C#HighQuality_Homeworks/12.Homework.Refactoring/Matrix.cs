using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatrixTask
{
    public class RotatingMatrix
    {
        private int size;
        private int row;
        private int col;
        private int[,] field;

        public RotatingMatrix(int size)
        {
            this.field = new int[size, size];
            this.Size = size;
        }

        public int Size
        {
            get { return size; }
            set { size = value; }
        }
        public int Row
        {
            get { return row; }
            set { row = value; }
        }

        public int Col
        {
            get { return col; }
            set { col = value; }
        }

        public int this[int row,int col]
        {
            get
            {
                return this.field[row, col];
            }
            set
            {
                this.field[row,col]= value;
            }
        }

        public void FindFreeCell(ref int row, ref int col)
        {
            for (int i = 0; i < this.field.GetLength(0); i++)
            {
                for (int j = 0; j < this.field.GetLength(0); j++)
                {
                    if (field[i, j] == 0)
                    {
                        row = i; col = j;
                        return;
                    }
                }
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

        public void Fill()
        {
            int dx = 1,
               dy = 1,
               row = 0,
               col = 0,
               currentNumber = 1;


            for (int i = 0; i < this.Size * this.Size; i++)
            {
                this[row, col] = currentNumber;

                if (this.NextCellIsFree(row, col))
                {
                    while ((row + dx >= this.Size
                   || row + dx < 0
                   || col + dy >= this.Size
                   || col + dy < 0
                   || this[row + dx, col + dy] != 0))
                    {
                        this.ChangeDirection(ref dx, ref dy);
                    }

                    row += dx;
                    col += dy;
                }
                else
                {
                    this.FindFreeCell(ref row, ref col);

                    dx = 1;
                    dy = 1;
                }

                currentNumber++;
            }
        }

        private void ChangeDirection(ref int dx, ref int dy)
        {
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };

            int currentDir = 0;
            for (int i = 0; i < 8; i++)
                if (dirX[i] == dx && dirY[i] == dy)
                {
                    currentDir = i;
                    break;
                }

            if (currentDir == 7)
            {
                dx = dirX[0];
                dy = dirY[0];
                return;
            }

            dx = dirX[currentDir + 1];
            dy = dirY[currentDir + 1];
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            for (int i = 0; i < this.Size; i++)
            {
                for (int j = 0; j < this.Size; j++)
                {
                    sb.AppendFormat("{0,3}", this[i, j]);
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}

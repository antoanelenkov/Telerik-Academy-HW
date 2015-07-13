namespace Statements
{
    public class ConditionalStatements
    {
        public static void Main()
        {
            Potato potato = new Potato();
            // ... 
            if (potato != null)
            {
                if (potato.IsRotten)
                {
                    GiveToChickens(potato);
                }
                else if (!potato.HasBeenPeeled)
                {
                    PeelPotato(potato);
                }
                else
                {
                    Cook(potato);
                }
            }
            else
            {
                System.Console.WriteLine("There is ni potato :(");
            }

            // Second part of the task  
            const int MIN_X = 0;
            const int MAX_X = 10;
            int x = 5;

            const int MIN_Y = 0;
            const int MAX_Y = 10;
            int y = 5;

            bool isValidX = x >= MIN_X && x <= MAX_X ? true : false;
            bool isValidY = y >= MIN_Y && y <= MAX_Y ? true : false;

            bool shouldVisitCell = true;

            if (shouldVisitCell && isValidX && isValidY)
            {
                VisitCell();
            }
        }

        private static void VisitCell()
        {
            throw new System.NotImplementedException();
        }

        private static void GiveToChickens(Potato potato)
        {
            throw new System.NotImplementedException();
        }

        private static void PeelPotato(Potato potato)
        {
            throw new System.NotImplementedException();
        }

        private static void Cook(Potato potato)
        {
            throw new System.NotImplementedException();
        }
    }
}

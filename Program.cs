namespace pmphw4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string E = Console.ReadLine();
            char[] seconds = new char[E.Length / 2];
            char[] thirds = new char[E.Length / 3];
            char[] fourths = new char[E.Length / 4];
            string outStr = String.Empty;

            int currIndex = 0;
            for (int i = 0; i < E.Length; i++)
            {
                if ((i+1)%2 == 0)
                {
                    seconds[currIndex] = E[i];
                    currIndex++;
                }
            }
            currIndex = seconds.Length - 1;
            for (int i = 0; i < E.Length; i++) {
                if ((i+1)%2 == 0)
                {
                    outStr += seconds[currIndex];
                    currIndex--;
                }
                else
                {
                    outStr += E[i];
                }
            }

            E = outStr;
            outStr = String.Empty;
            currIndex = 0;
            char tmpChar;

            // 3.karakterek kivalogatasa
            if (E.Length > 2) {
                for (int i = 0;i < E.Length; i++)
                {
                    if ((i+1) % 3 == 0)
                    {
                        thirds[currIndex] = E[i];
                        currIndex++;
                    }
                }
                tmpChar = thirds[0];
                for (int i = 0; i < thirds.Length - 1; i++)
                {
                    thirds[i] = thirds[i + 1];
                }
                thirds[thirds.Length - 1] = tmpChar;
                currIndex = 0;
                for (int i = 0; i < E.Length; i++)
                {
                    if ((i+1)%3 == 0)
                    {
                        outStr += thirds[currIndex];
                        currIndex++;
                    }
                    else
                    {
                        outStr += E[i];
                    }
                }

                E = outStr;
                outStr = String.Empty;
                currIndex = 0;
            }
            // 4. karakter kivalogatasa
            if (E.Length > 3) {
                for (int i = 0; i < E.Length; i++)
                {
                    if ((i+1) % 4 == 0)
                    {
                        fourths[currIndex] = E[i];
                        currIndex++;
                    }
                }

                tmpChar = fourths[fourths.Length - 1];
                for (int i = fourths.Length - 1; i > 0; i--)
                {
                    fourths[i] = fourths[i - 1];
                }
                fourths[0] = tmpChar;
                currIndex = 0;
                for (int i = 0; i < E.Length; i++)
                {
                    if ((i+1) % 4 == 0)
                    {
                        outStr += fourths[currIndex];
                        currIndex++;
                    }
                    else
                    {
                        outStr += E[i];
                    }
                }
                E = outStr;
                outStr = String.Empty;
            }

            int numberOfSpaces = 0;
            // Szavak karakterszamanak a megforsitasa
            for (int i = 0; i < E.Length;i++)
            {
                if (Char.IsWhiteSpace(E[i]))
                {
                    numberOfSpaces++;
                }
            }
            if (numberOfSpaces == 0)
            {
                Console.WriteLine(E);
            }
            else
            {
                int[] numberOfCharacters = new int[numberOfSpaces + 1];
                for (int i = 0; i < numberOfCharacters.Length; i++)
                {
                    numberOfCharacters[i] = 0;
                }
                string textWithoutSpaces = String.Empty;
                currIndex = 0;
                for (int i = 0;i < E.Length;i++)
                {
                    if (!Char.IsWhiteSpace(E[i]))
                    {
                        numberOfCharacters[currIndex] += 1;
                        textWithoutSpaces += E[i];
                    }
                    else
                    {
                        currIndex++;
                    }
                }
                int[] tmpNumOfChars = new int[numberOfCharacters.Length];
                currIndex = 0;
                for (int i = numberOfCharacters.Length - 1; i >= 0; i--)
                {
                    tmpNumOfChars[currIndex] = numberOfCharacters[i];
                    currIndex++;
                }
                numberOfCharacters = tmpNumOfChars;
                currIndex = 0;
                for (int i = 0; i < numberOfCharacters.Length; i++)
                {
                    for (int j = 0; j < numberOfCharacters[i]; j++)
                    {
                        outStr += textWithoutSpaces[currIndex];
                        currIndex++;
                    }
                    outStr += " ";
                }
                E = outStr;
                outStr = String.Empty;
                for (int i = 0; i < E.Length - 1; i++)
                {
                    outStr += E[i];
                }
                Console.WriteLine(outStr);
            }

        }
    }
}
using System;

namespace Interpolations
{
    class Program
    {
        static void Main(string[] args)
        {

            //Exemple of interpolation with strings//

            string fullname = "Fran Sabino";
            string subjects = "Math, English, Portuguese, Grammar";
            string grades = "A, B, C , D";
            string fullInfo = $"Full name: {fullname}, \rSubjects: {subjects}, \rYour grades is: {grades}";
            Console.WriteLine(fullInfo);
        }
    }
}

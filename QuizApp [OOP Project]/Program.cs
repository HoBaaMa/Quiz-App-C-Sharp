namespace QuizApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quetions[] quetions = new Quetions[]
            {
                new Quetions("What is the capital of France?", new string[] { "Paris", "London", "Berlin", "Madrid" }, 0),
                new Quetions("What is the capital of Germany?", new string[] { "Paris", "London", "Berlin", "Madrid" }, 2),
                new Quetions("What is the capital of Spain?", new string[] { "Paris", "London", "Berlin", "Madrid" }, 3),
                new Quetions("What is the capital of UK?", new string[] { "Paris", "London", "Berlin", "Madrid" }, 1),
                new Quetions("What is the capital of Cairo?", new string[] {"Alexandria", "Cairo", "Minya", "Luxor" }, 1),
                new Quetions("What is the capital of Sadui Arabia?", new string[] {"Riyadh", "Jeddah", "Dammam", "Mecca" }, 1),
                new Quetions ("What is the capital of Japan?", new string[] {"Tokyo", "Osaka", "Kyoto", "Hiroshima" }, 0),
            };

            // Initialize the quiz with the questions
            Quiz quiz = new Quiz(quetions);

            // Start the quiz
            quiz.StartQuiz();

            // Wait for user input before closing the program
            Console.ReadKey();
        }
    }
}

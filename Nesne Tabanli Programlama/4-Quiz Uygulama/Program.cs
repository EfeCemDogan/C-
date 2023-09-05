using System;
using System.Globalization;


namespace ConsoleApp
{

    // Aslında bu metod sorularla oynamak için var
    class Question  // Obje Sınıf
    {
        public Question(string text, string[] choices, string answer)  
        // Metod dışarıdan küçükharf
        {
            this.Text = text;  //Dışarıdan gelen cevaplar içeriyi eşitleme
            this.Choices = choices;
            this.Answer = answer;
        }

        public string Text { get; set; }  //Metod içeride ki cevap
        public string[] Choices { get; set; }
        public string Answer { get; set; }

        public bool checkAnswer(string answer) // Metod cevabı kontrol eden
        {
            return this.Answer.ToLower() == answer.ToLower();
        }
    }

 class Quiz
    {
        public Quiz(Question[] questions)
        {
            this.Questions = questions;
            this.QuestionIndex = 0;
            this.Score = 0;
        }
        private Question[] Questions { get; set; }
        private int QuestionIndex { get; set; }
        private int Score { get; set; }

        private Question GetQuestion()
        {
            return this.Questions[this.QuestionIndex];
        }

        public void DisplayQuestion()
        {
            var question = this.GetQuestion();
            this.DisplayProgress();
            Console.WriteLine($"soru {this.QuestionIndex + 1}: {question.Text}");

            foreach (var c in question.Choices)
            {
                Console.WriteLine($"-{c}");
            }

            Console.Write("cevap: ");
            var cevap = Console.ReadLine();
            this.Guess(cevap);
        }

        private void Guess(string answer)
        {
            var question = this.GetQuestion();
            if (question.checkAnswer(answer))
                this.Score++;
            this.QuestionIndex++;

            if (this.Questions.Length == this.QuestionIndex)
            {
                this.DisplayScore();
            }
            else
            {                
                this.DisplayQuestion();
            }

        }
        private void DisplayScore()
        {
            Console.WriteLine($"Score: {this.Score}");
        }

        private void DisplayProgress()
        {
            int totalQuestion = this.Questions.Length;
            int questionNumber = this.QuestionIndex+1;

            if (totalQuestion>=questionNumber)
                Console.WriteLine($"Question {questionNumber} of {totalQuestion}");
        }

    }

    class Program
    {
      
        static void Main(string[] args)
        {

            var q1 = new Question("En iyi programlama dili hangisidir?", new string[] { "Python", "C#", "Java", "C++" }, "C#");
            var q2 = new Question("En popüler programlama dili hangisidir?", new string[] { "C#", "Python", "Java", "C++" }, "C#");
            var q3 = new Question("En çok kazandıran programlama dili hangisidir?", new string[] { "C#", "Java", "Python", "C++" }, "C#");

            var questions = new Question[] { q1, q2, q3 };
            var quiz = new Quiz(questions);


            quiz.DisplayQuestion();
            
        }
    }
}

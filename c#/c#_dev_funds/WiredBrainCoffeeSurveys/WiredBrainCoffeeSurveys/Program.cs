using System;
using System.Collections.Generic;
using System.IO;

namespace WiredBrainCoffeeSurveys
{
    class Program
    {
        static void Main(string[] args)
        {
            bool quitApp = false;

            do
            {
                Console.WriteLine("Please specify a report to run (rewards, comments, tasks, quit):");
                var selectedReport = Console.ReadLine();

                switch (selectedReport)
                {
                    case "rewards":
                        GenerateWinnerEmails(surveyResults);
                        break;

                    case "comments":
                        GenerateCommentsReport(surveyResults);
                        break;

                    case "tasks":
                        GenerateTasksReport(surveyResults);
                        break;

                    case "quit":
                        quitApp = true;
                        break;

                    default:
                        Console.WriteLine("Sorry, that is not a valid option.");
                        break;
                }

                Console.WriteLine();
            }
            while (!quitApp);
        }

        private static void GenerateWinnerEmails(SurveyResults results)
        {
            var selectedEmails = new List<string>();
            int counter = 0;

            while (selectedEmails.Count < 2 && counter < results.Responses.Count)
            {
                var currentItem = results.Responses[counter];

                if (currentItem.FavoriteProduct == "Cappucino")
                {
                    selectedEmails.Add(currentItem.EmailAddress);
                    Console.WriteLine(currentItem.EmailAddress);
                }

                counter++;
            }
        }

        private static void GenerateCommentsReport(SurveyResults results)
        {
            var comments = new List<string>();
            Console.WriteLine(Environment.NewLine + "Comments Output:");

            for (var i = 0; i < results.Responses.Count; i++)
            {
                var currentResponse = results.Responses[i];

                if (currentResponse.WouldRecommend < 7.0)
                {
                    Console.WriteLine(currentResponse.Comments);
                    comments.Add(currentResponse.Comments);
                }
            }

            Console.WriteLine();

            foreach (var response in results.Responses)
            {
                if (response.AreaToImprove == results.AreaToImprove)
                {
                    Console.WriteLine(response.Comments);
                    comments.Add(response.Comments);

                }
            }

            File.WriteAllLines("CommentsReport.csv", comments);
        }

        public static void GenerateTasksReport(SurveyResults results)
        {
            var tasks = new List<string>();

            // Calculated values
            double responseRate = results.NumberResponded / results.NumberSurveyed;
            double unansweredCount = results.NumberSurveyed - results.NumberResponded;
            double overallScore = (results.ServiceScore + results.CoffeeScore + results.FoodScore + results.PriceScore) / 4;

            //Console.WriteLine($"Response Percentage: {responseRate}");
            //Console.WriteLine($"Unanswered Surveys: {unansweredCount}");
            //Console.WriteLine($"Overall Score: {overallScore}");

            // Logical comparisons
            bool isCoffeeScoreLower = results.CoffeeScore < results.FoodScore;
            //bool higherCoffeeScore = results.CoffeeScore > results.FoodScore;
            //bool customerRecommend = results.WouldRecommend >= 7;
            //bool noGranolaYesCappucino = results.LeastFavoriteProduct == "Granola" && results.FavoriteProduct == "Cappucino";

            //Console.WriteLine($"Coffe Score Higher Than Food: {higherCoffeeScore}");
            //Console.WriteLine($"Customers Would Recommend Us: {customerRecommend}");
            //Console.WriteLine($"Hate Granola, Love Cappucino: {noGranolaYesCappucino}");

            if (isCoffeeScoreLower)
            {
                tasks.Add("Investigate coffee recipes and ingrtedients.");
            }

            if (overallScore > 8.0)
            {
                tasks.Add("Work with leadership to reward staff.");
            }
            else
            {
                tasks.Add("Work with employees for improvement ideas.");
            }

            tasks.Add(results.AreaToImprove switch
            {
                "RewardsProgram" => "Reviit the rewards deals.",
                "Cleanliness" => "Contact the cleaning vendor.",
                "MobileApp" => "Contact the consulting firm about the app.",
                _ => "Investigate individual comments for ideas."
            });

            foreach (string task in tasks)
            {
                Console.WriteLine(task);
            }
        }
    }
}
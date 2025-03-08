using System;

namespace Lab3Q3
{
    class MealCard
    {
        private string studentName;
        private int balance;

        public MealCard(string name, int initialBalance = 100)
        {
            studentName = name;
            balance = initialBalance;
        }

        public void AddPoints(int points)
        {
            if (points > 0)
            {
                balance += points;
                Console.WriteLine($"{points} points have been added. Updated balance: {balance}.");
            }
            else
            {
                Console.WriteLine("Invalid amount. Please add a positive number of points.");
            }
        }

        public void PurchaseFood(int points)
        {
            if (points > 0 && balance >= points)
            {
                balance -= points;
                Console.WriteLine($"Purchase completed! {points} points deducted. Remaining balance: {balance}.");
            }
            else if (points <= 0)
            {
                Console.WriteLine("Invalid purchase amount. Please enter a positive number.");
            }
            else
            {
                Console.WriteLine("Not enough balance. Purchase declined.");
            }
        }

        public void DisplayBalance()
        {
            Console.WriteLine($"{studentName}'s current balance: {balance} points.");
        }
    }
}
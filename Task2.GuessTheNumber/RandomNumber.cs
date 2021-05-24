using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.GuessTheNumber
{
    class RandomNumber
    {
        int value;
        int steps;

        public int Value { get { return this.value; } }
        public int Steps { get { return this.steps; } }

        public RandomNumber(int max)
        {
            start(max);
        }

        public void start(int max)
        {
            Random rand = new Random();
            this.value = rand.Next(0, max + 1);
        }

        public string CheckValue(out bool check, int userAnswer)
        {
            if (userAnswer == this.value)
            {
                check = true;
                return $"Поздравляю, вы угадали! Количество ходов: {this.steps}";
            }
            else if (userAnswer > this.value)
            {
                check = false;
                steps++;
                return $"Число слишком большое, попробуйте ещё раз!";
            }
            else
            {
                check = false;
                steps++;
                return $"Число слишком маленькое, попробуйте ещё раз!";
            }
        }

        public void Reset(int max)
        {
            start(max);
            this.steps = 0;
        }

    }
}
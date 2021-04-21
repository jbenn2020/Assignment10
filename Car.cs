using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaUnitTestExample
{
    //Car Constructor
    public enum Condition { BAD, FAIR, GOOD, EXCELLENT };

    public class Car
    {
        public string Make;
        //public int Speed;     //Doesn't work like this.
        private int newSpeed;
        public object Condition;

        //Allows for 5/6 tests to pass by having a constructor that TestConstructor() can actually use
        public Car(string Make, object Condition)
        {
            this.Make = Make;
            this.Condition = Condition;
        }

        //Allows the TestSpeed() test to pass by forcing the speed to be a certain value given the conditions.
        //If it's higher than 200, set it to 200, if it's lower than -50, set it to -50, otherwise use whatever the value given is.
        //It essentially makes sure the speed is only between -50 and 200.

        public int Speed
        {
            get => newSpeed;
            set
            {
                if (value > 200)
                {
                    newSpeed = 200;
                }
                else if (value < -50)
                {
                    newSpeed = -50;
                }
                else
                {
                    newSpeed = value;
                }
            }
        }
    }
}

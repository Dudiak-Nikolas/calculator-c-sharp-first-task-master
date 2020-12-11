﻿using Calculator.Models.Calculation.Operations.Base;

namespace Calculator.Models.Calculation.Operations.ArithmeticOperations
{
    class Division : BinaryOperation
    {
        public Division(UniversalOperation leftArg, UniversalOperation rightArg) : base(leftArg, rightArg) { }

        public override double Operation()
        {
            return leftArg.Operation() / rightArg.Operation();
        }
    }
}
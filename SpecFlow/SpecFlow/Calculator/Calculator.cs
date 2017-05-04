using System.Diagnostics.CodeAnalysis;

namespace SpecFlow.Calculator
{
    [SuppressMessage("ReSharper", "MethodNameNotMeaningful")]
    public class Calculator
    {
        public long FirstNumber { get; set; }
        public long SecondNumber { get; set; }
        public long Result { get; private set; }
        
        public long Add() => Result = FirstNumber + SecondNumber;
    }
}
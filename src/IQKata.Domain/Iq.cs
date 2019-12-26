using System;
using System.Linq;


namespace IQKata.Domain
{
  
    public class Iq
    {
        public static int Test(string numbers)
        {
            //Your code is here...
            var numberList = numbers.Split(" ").Select(x => Convert.ToInt32(x)).ToList();
            var evenList = numberList.FindAll(IsEven);
            var oddList = numberList.FindAll(IsOdd);
            if(evenList.Count==1)
                return numberList.IndexOf(evenList.FirstOrDefault())+1;
            if (oddList.Count == 1)
                return numberList.IndexOf(oddList.FirstOrDefault())+1;
            throw new Exception();
        }
        private static bool IsEven(int i) 
        { 
            return i % 2 == 0; 
        } 
        private static bool IsOdd(int i) 
        { 
            return i % 2 != 0; 
        } 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.UsoltsevAD.Sprint1.Task6.V8.Lib
{
    public class DataService : ISprint1Task6V8
    {
        public string MoveLetterToEnd(string value)
        {
            string[] words = value.Split(' ');
            string[] modifiedWords = new string[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                char firstLetter = words[i][0];
                modifiedWords[i] = words[i].Substring(1) + firstLetter;
            }
            string combinedWords = string.Join(" ", modifiedWords);
            return combinedWords;
        }
    }
}

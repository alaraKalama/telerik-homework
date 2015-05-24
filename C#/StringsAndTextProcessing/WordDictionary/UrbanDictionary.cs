using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordDictionary
{
    class UrbanDictionary
    {
        private static SortedDictionary<string, string> urban = new SortedDictionary<string, string>();
        
        static void Main()
        {
            UrbanDictionary(urban);

            Console.WriteLine("Here are some words you maybe know, or maybe you don't:");
            Console.WriteLine("Banana? Duff? Cellfish? Programmer's Interface? Or jigaboo?");
            Console.WriteLine("Or abc sex, or alex, yes Alex! Code? Programphile is interesting...");
            Console.WriteLine("Enter the word you would like to get the meaning for:");
            string input = Console.ReadLine().ToLower();
            string result = string.Empty;
            if (urban.ContainsKey(input))
            {
                urban.TryGetValue(input, out result);
            }
            else
            {
                Console.WriteLine("Not in this dictionary:) Or maybe you misspelled it?");
            }

            Console.WriteLine(result);
        }

        static void UrbanDictionary (SortedDictionary<string, string> urban)
        {
            urban.Add("jigaboo", "The funniest sounding racial slur known to man. Used mainly by whites to disparage black people.");
            urban.Add("duff", "Designated Ugly Fat Friend");
            urban.Add("mostool", "One who is drunk or high. A sh*thead to some or simply crap/garbage.");
            urban.Add("most wursterest", "when the shit hits the fan at high speed. also when things are very bad");
            urban.Add("abc sex", "Sex only on Anniversaries, Birthdays and Christmas");
            urban.Add("alex", "Someone that is of extreme greatness. Often considered as a god in some religions. Also means cool.");
            urban.Add("banana", "An asian person who acts like they are white. Yellow on the outside, white on the inside.");
            urban.Add("cellfish", "An individual who talks on his or her cell phone even when doing so is rude or inconsiderate of other people.");
            urban.Add("programmer's tan", "The pasty white tan of a person who works over eighty hours a week and never gets any sun.");
            urban.Add("programmer", "An organism capable of converting caffeine into code.");
            urban.Add("programming telekinetically", "The practice of programming a computer without touching an input device of any kind, such as a keyboard or mouse. Easily confused with doing nothing at all.");
            urban.Add("programphile", "Erotic attraction to or sexual contact with software. ");
            urban.Add("code", "The way a GHETTO ASS black person pronounces the word cold.");
            urban.Add("programmer's interface", "Programmer's Interface usually includes: Dark circles around the eyes, Bloodshot eyes, Pale skin, Stubble (if male)");
        }
    }
}

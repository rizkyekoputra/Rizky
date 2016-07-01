using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string referal_text = @"[{""name"":""Anggi"",""referral_used"" : ""Frila""},
                        {""name"" : ""Boboy"", ""referral_used"" : ""Anggi""},
                        {""name"" : ""Caca"", ""referral_used"" : ""Anggi""},
                        {""name"" : ""Dea"", ""referral_used"" : ""Boboy""},
                        {""name"" : ""Ebi"", ""referral_used"" : ""Boboy""},
                        {""name"" : ""Frila"", ""referral_used"" : ""Caca""}]";

            

            Console.ReadKey();
        }

        public class User
        {
            public User(string json)
            {
                User deserial =
            }

            string name { get; set; }
            string referral_used { get; set; }
        }
        
    }
}

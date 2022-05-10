using System;
using BankApplication;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Globalization;

namespace BankApplication
{
 

    internal class Program
    {
        private static void Main(string[] args)
        {
            Wallet wallet = new Wallet("Steven", 21, 100.0, 25.50);
            Console.WriteLine($"Funds: {wallet.WalletMoney}");
            Console.WriteLine($"Price: {wallet.Prices}");

            if(wallet.WalletMoney > wallet.Prices)
            {
                Console.WriteLine($"Purchase has went through" );
                double remaining = wallet.WalletMoney - wallet.Prices;
                Console.WriteLine($"Remaining: {remaining}");
            }
            
            
            

        
        }


    }
}

 
























//        public static bool IsValidEmail(string email)
//        {
//            if (string.IsNullOrWhiteSpace(email))
//                return false;

//            try
//            {
//                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
//                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

//                string DomainMapper(Match match)
//                {
//                    var idn = new IdnMapping();

//                    string domainName = idn.GetAscii(match.Groups[2].Value);

//                    return match.Groups[1].Value + domainName;
//                }
//            }
//            catch (RegexMatchTimeoutException e)
//            {
//                return false;
//            }
//            catch (ArgumentException e)
//            {
//                return false;
//            }

//            try
//            {
//                return Regex.IsMatch(email,
//                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
//                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
//            }
//            catch (RegexMatchTimeoutException)
//            {
//                return false;
//            }
//        }
//    }
//}














//            private static string[] CapitalizeNames(string[] names)
//            {
//                string[] capitalizedNames = new string[names.Length];
//                for (int i = 0; i < names.Length; i++)
//                {
//                    char[] characterArray = names[i].ToCharArray();
//                    for (int j = 0; j < characterArray.Length; j++)
//                    {
//                        if (j == 0)
//                        {
//                            string firstLetter = characterArray[0].ToString().ToUpper();
//                            characterArray[0] = Convert.ToChar(firstLetter);
//                        }
//                        else
//                        {
//                            string followingLetter = characterArray[j].ToString().ToLower();
//                            characterArray[j] = followingLetter.ToCharArray()[0];
//                        }
//                    }
//                    capitalizedNames[i] = string.Join("", characterArray);
//                }

//                return capitalizedNames;
//            }
//        }
//    }


//}

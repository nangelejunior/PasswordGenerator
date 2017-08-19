using System;
using System.Collections.Generic;
using System.Net;
using System.ServiceModel.Web;

namespace WcfPasswordGenerator
{
    public class PasswordGenerator : IPasswordGenerator
    {
        Random random = new Random();

        public string[] GetPasswords(string characters, int minSize, int maxSize, int numberPasswords)
        {
            try
            {
                List<string> passwords = null; // new List<string>();
                for (int i = 0; i < numberPasswords; i++)
                    passwords.Add(RandomString(characters, minSize, maxSize));

                return passwords.ToArray();
            }
            catch (Exception ex)
            {
                throw new WebFaultException<CustomException>(new CustomException() 
                { 
                    ExceptionMessage = ex.Message, 
                    StackTrace = ex.StackTrace 
                }, HttpStatusCode.InternalServerError);
            }
        }

        private string RandomString(string characters, int minSize, int maxSize)
        {
            int n = RandomLength(minSize, maxSize);
            string c = string.Empty;
            for (int i = 0; i < n; i++)
                c += RandomChar(characters);

            return c;
        }

        private char RandomChar(string characters)
        {
            int i = (random.Next() + 1) % (characters.Length - 1);
            if (i < 0)
                i = -i;

            return characters[i];
        }

        private int RandomLength(int min, int max)
        {
            int n = (max - min) + 1;
            int i = (random.Next() + 1) % n;
            if (i < 0)
                i = -i;

            return (min + i);
        }
    }
}

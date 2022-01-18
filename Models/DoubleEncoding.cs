using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HistoryServer.Models
{
    public class DoubleEncoding
    {
        static string allowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZабвгдеёжзийклмнопрстуфхцчшщьыъэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЬЫЪЭЮЯ @!?.,/\\_=-+0123456789~#:;\'\"";
        public string Encode(string UTFval)
        {
            string encoded = "";
            for (int i = 0; i < UTFval.Length; i++)
            {
                char ch = UTFval[i];
                encoded += allowedChars.IndexOf(ch);
                if (i == UTFval.Length - 1) continue; //skip last one, dont add a point at the end
                encoded += "."; // adds "." only inbetween characters
            }
            return encoded; // string format: {indexOf1Char}.{indexOf2Char}.{indexOf3Char}......
        }
        public string Decode(string ENCval)
        {
            string decoded = "";
            foreach (string chnum in ENCval.Split(".")) // loop thru the array of indexies
            {
                int num = Convert.ToInt32(chnum);
                decoded += (num >= 0 && num < allowedChars.Length) ? allowedChars[num] : 'ඞ'; // unknown char is amongus
            }
            return decoded;
        }
    }
}

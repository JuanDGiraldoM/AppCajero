﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AppCajero
{
    public static class Utilidades
    {
        public static List<T> Shuffle<T>(this List<T> original)
        {
            T[] shuffled = original.ToArray();

            for (int index = shuffled.Length - 1; index > 0; index--)
            {
                int randomIndex = new Random().Next(index);

                T temp = shuffled[index];
                shuffled[index] = shuffled[randomIndex];
                shuffled[randomIndex] = temp;
            }

            return shuffled.ToList();
        }

        public static string GetMd5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));            
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        public static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            string hashOfInput = GetMd5Hash(md5Hash, input);
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            if (0 == comparer.Compare(hashOfInput, hash))
                return true;
            else
                return false;
        }
    }
}
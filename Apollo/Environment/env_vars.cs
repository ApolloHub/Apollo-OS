﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace Apollo.Environment
{
    public class UsefulFunctions
    {
        public static string CalculateMD5Hash(string input)
        {
            // step 1, calculate MD5 hash from input
            MD5 md5 = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();

        }
    }
    public class KernelVariables
    {
        public static string user;
        public static string rootdir = @"0:\";
        public static string currentdir = rootdir;
        
        public static string etcdir = rootdir + "etc";
        public static string bindir = rootdir + "bin";
        public static string sbindir = rootdir + "sbin";
        public static string procdir = rootdir + "proc";
        public static string usrdir = rootdir + "usr";
        public static string homedir = rootdir + "home";
        public static string rootusrdir = rootdir + "root";
        public static string tmpdir = rootdir + "tmp";
        public static string vardir = rootdir + "var";
        public static string srvdir = rootdir + "srv";
        public static string libdir = rootdir + "lib";
        public static string optdir = rootdir + "opt";
        public static string devdir = rootdir + "dev";
    }
    class env_vars
    {
        public static void PressAnyKey()
        {
            PressAnyKey("Press any key to continue...");
        }
        public static void PressAnyKey(string text)
        {
            Console.WriteLine(text);
            Console.ReadKey(true);
        }
    }
}

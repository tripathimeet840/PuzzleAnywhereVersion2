using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringDictionary : MonoBehaviour
{
    public static string A = "Apple";
    public static string B = "Bat";
    public static string C = "Cat";
    public static string D = "Dog";
    public static string E = "Elephant";
    public static string F = "Fish";
    public static string G = "Gift";
    public static string H = "Helicopter";
    public static string I = "Injection";
    public static string J = "JellyFish";
    public static string K = "kite";
    public static string L = "Lion";
    public static string M = "Moon";
    public static string N = "Notebook";
    public static string O = "Octo";
    public static string P = "Pizza";
    public static string Q = "Question";
    public static string R = "RadioBox";
    public static string S = "Snake";
    public static string T = "Trophy";
    public static string U = "Umbrella";
    public static string V = "Violin";
    public static string W = "Watermelon";
    public static string X = "XmasTree";
    public static string Y = "Yarn";
    public static string Z = "Zebra";
    public static string Homescene = "HomeScene";
    public static string Gamescene = "GameScene";
    public static string LastPlayed = "LastPlayed";
    

    public static Dictionary<char, string> charValues = new Dictionary<char, string>()
    {
        { 'A', "Apple" },
        { 'B', "Bat" },
        { 'C', "Cat" },
        { 'D', "Dog" },
        { 'E', "Elephant" },
        { 'F', "Fish" },
        { 'G', "Gift" },
        { 'H', "Helicopter" },
        { 'I', "Injection" },
        { 'J', "JellyFish" },
        { 'K', "kite" },
        { 'L', "Lion" },
        { 'M', "Moon" },
        { 'N', "Notebook" },
        { 'O', "Octo" },
        { 'P', "Pizza" },
        { 'Q', "Question" },
        { 'R', "RadioBox" },
        { 'S', "Snake" },
        { 'T', "Trophy" },
        { 'U', "Umbrella" },
        { 'V', "Violin" },
        { 'W', "Watermelon" },
        { 'X', "XmasTree" },
        { 'Y', "Yarn" },
        { 'Z', "Zebra" }
    };

    //String ReturnRequiredString(string str)
    //{
    //    for (int i = 'A'; i<='Z';i++) 
    //    {

    //        if (i == 'A')
    //        {
    //            return A;
    //        }
    //        if (i == 'B')
    //        {
    //            return A;
    //        }
    //        if (i == 'C')
    //        {
    //            return A;
    //        }
    //        if (i == 'A')
    //        {
    //            return A;
    //        }
    //        if (i == 'A')
    //        {
    //            return A;
    //        }
    //        if (i == 'A')
    //        {
    //            return A;
    //        }
    //        if (i == 'A')
    //        {
    //            return A;
    //        }
    //        if (i == 'A')
    //        {
    //            return A;
    //        }
    //        if (i == 'A')
    //        {
    //            return A;
    //        }
    //        if (i == 'A')
    //        {
    //            return A;
    //        }
    //        if (i == 'A')
    //        {
    //            return A;
    //        }
    //        if (i == 'A')
    //        {
    //            return A;
    //        }
    //        if (i == 'A')
    //        {
    //            return A;
    //        }
    //        if (i == 'A')
    //        {
    //            return A;
    //        }
    //        if (i == 'A')
    //        {
    //            return A;
    //        }
    //        if (i == 'A')
    //        {
    //            return A;
    //        }
    //        if (i == 'A')
    //        {
    //            return A;
    //        }
    //        if (i == 'A')
    //        {
    //            return A;
    //        }
    //        if (i == 'A')
    //        {
    //            return A;
    //        }
    //        if (i == 'A')
    //        {
    //            return A;
    //        }
    //        if (i == 'A')
    //        {
    //            return A;
    //        }
    //        if (i == 'A')
    //        {
    //            return A;
    //        }
    //        if (i == 'A')
    //        {
    //            return A;
    //        }
    //        if (i == 'A')
    //        {
    //            return A;
    //        }


    //    }

    //    return A;

    //}

    //private void Start()
    //{
    //    for (char i = 'A'; i < 'Z'; i++)
    //    {
    //        temk.Add(StringDictionary.print());
    //    }
    //}

}

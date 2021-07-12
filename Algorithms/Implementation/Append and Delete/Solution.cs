using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class MainClass {
  public static void Main (string[] args) {
    string s = "ashley"; string t = "ash"; int k = 2;
    string result = "ERROR";
        
     //if s == t then we just run an equation to determine if it can be done
    if(s.Equals(t))
    {
      result = (k >= s.Length*2 || k % 2 == 0) ? "Yes" : "No";
    }
        else//count how many characters they share, starting from the front of the string
        {
            int matchingCharacters = 0;
            
            for(int i = 0; i < Math.Min(s.Length, t.Length); i++)
            {
                //ado
                //adolol
                if(s[i] != t[i])
                {    
                    break;
                }
                matchingCharacters++;
            }
            
            int nonMatchingCharactersInS = s.Length - matchingCharacters;
            int nonMatchingCharactersInT = t.Length - matchingCharacters;
            
            //I reassign here to make the conditions more readable down below
            int nmcS = nonMatchingCharactersInS;
            int nmcT = nonMatchingCharactersInT;
            
            //use the number of non matching characters in an equation to determine if it can be done
            
            //Naming the conditions to increase readability
            bool conditionA = nmcS + nmcT == k;
            bool conditionB = (nmcS + nmcT < k && (nmcS + nmcT - k) % 2 == 0 );
            bool conditionC = s.Length + t.Length <= k;
            
            result = (conditionA || conditionB || conditionC) ? "Yes" : "No";
            
        }
        
        Console.WriteLine(result);
  }
}
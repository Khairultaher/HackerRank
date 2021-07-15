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
      int a = 17; int b = 24;
      var lower = Math.Ceiling(Math.Sqrt(a));
      var higher = Math.Floor(Math.Sqrt(b));

      if(lower>higher){
         //return 0;
         Console.WriteLine(0);
      }

    
      int counter = 0;
      for(var  i = lower; i <= higher; i++ )
      {
           var ii = i*i;
          if(ii >= a && ii <= b)
          {
              counter++;
          }
      }   
      //return counter;
      Console.WriteLine(counter);
    }
}

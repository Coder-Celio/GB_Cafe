﻿//Fields 

//Its a variable that declared directly inside a Type(Class)
//Also a member of a Class 

//has Access modifiers:
//public -> every other Type has access
//private -> Only the Containing class has access to the field
//protected -> Only Inheriting members can access the field
//internal -> The field can only be used by it's assembly

using Classes;
using System;

//new Donut () is using C# default constructor.
Donut doug = new Donut();
System.Console.WriteLine(doug);

System.Console.WriteLine("------------");

doug._donutType = "Jelly Filled";
System.Console.WriteLine(doug._donutType);

namespace Classes
{
    class Donut
    {
        //This is a string and its publicly accessible
               //type   //name
        public string? _donutType;

        public Donut(string donutType)
        {
            _donutType = donutType;
        }

        public Donut()
        {

        }
    }
}

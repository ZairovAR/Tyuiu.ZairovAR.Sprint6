﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZairovAR.Sprint6.Task5.V22.Lib
{
    public class DataService : ISprint6Task5V22
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path) 
        {
            using (StreamReader reader = new StreamReader(path)) 
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                { 
                    len++; 
                }
            }

            double[] numsArray = new double[len];

            int index = 0;
            using (StreamReader reader = new StreamReader(path)) 
            {
                string line;
                while (( line = reader.ReadLine()) != null) 
                {
                    numsArray[index] = Math.Round(Convert.ToDouble(line), 3);
                    index++;
                }
            }

            numsArray = numsArray.Where(val => val > 5).ToArray();

            return numsArray;
        }
    }
}

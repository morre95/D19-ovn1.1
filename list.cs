﻿using System;


namespace D19_ovn1._1
{
	public static class list
	{
		public static void All()
		{
			string[] lines = FileHelper.GetAll();
            foreach (string line in lines)
            {
                string[] parts = line.Split("|");
                Console.WriteLine($"{parts[0]} {parts[1]}");
            }
        }
	}
}

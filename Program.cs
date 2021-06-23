using System;
using EPPlusTest.View;

namespace EPPlusTest
{
	class Program
	{
		static void Main(string[] args)
		{
			using (ExcelData inputData = new ExcelData())
			{
				inputData.Load("Test.xlsx");
				for (int i = 1; i <=3; i++)
				{
					var data = inputData.GetText(i, 1);
					Console.WriteLine(data);
				}
			}
		}
	}
}

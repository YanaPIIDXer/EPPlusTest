using System;
using EPPlusTest.View;
using EPPlusTest.Controller;

namespace EPPlusTest
{
	class Program
	{
		static void Main(string[] args)
		{
			using (ExcelData inputData = new ExcelData())
			{
				using (ExcelData outputData = new ExcelData())
				{
					inputData.Load("Test.xlsx");
					outputData.Create("Output.xlsx");

					var swap = new SwapController(inputData, outputData);
					swap.Swap();
				}
			}
		}
	}
}

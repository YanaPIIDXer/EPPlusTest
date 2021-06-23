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
			}
		}
	}
}

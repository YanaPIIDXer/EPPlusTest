﻿using System;
using System.Collections.Generic;
using System.Text;
using OfficeOpenXml;
using System.IO;

namespace EPPlusTest.View
{
	/// <summary>
	/// エクセルデータ
	/// </summary>
	public class ExcelData : IDisposable
	{
		/// <summary>
		/// パッケージ
		/// </summary>
		private ExcelPackage package = null;

		/// <summary>
		/// ワークシート
		/// </summary>
		private ExcelWorksheet worksheet = null;

		/// <summary>
		/// 読み込み
		/// </summary>
		/// <param name="filePath">ファイルパス</param>
		public void Load(string filePath)
		{
			var file = File.OpenRead(filePath);
			package = new ExcelPackage(file);
			worksheet = package.Workbook.Worksheets[0];
		}

		/// <summary>
		/// 現在のワークシート切り替え
		/// </summary>
		/// <param name="index">インデックス</param>
		public void ChangeCurrentWorksheet(int index)
		{
			worksheet = package.Workbook.Worksheets[index];
		}

		/// <summary>
		/// 現在のワークシート切り替え
		/// </summary>
		/// <param name="name">ワークシート名</param>
		public void ChangeCurrentWowksheet(string name)
		{
			worksheet = package.Workbook.Worksheets[name];
		}

		/// <summary>
		/// デストラクタ
		/// </summary>
		~ExcelData()
		{
			Dispose();
		}

		/// <summary>
		/// 破棄
		/// </summary>
		public void Dispose()
		{
			if (package != null)
			{
				package.Dispose();
				package = null;
			}
		}
	}
}
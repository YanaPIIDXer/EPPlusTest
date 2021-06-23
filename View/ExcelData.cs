using System;
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
		/// 読み込み
		/// </summary>
		/// <param name="filePath">ファイルパス</param>
		public void Load(string filePath)
		{
			var file = File.OpenRead(filePath);
			package = new ExcelPackage(file);
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

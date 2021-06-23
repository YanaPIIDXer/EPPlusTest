using System;
using System.Collections.Generic;
using System.Text;
using OfficeOpenXml;
using System.IO;
using OfficeOpenXml.Drawing;

namespace EPPlusTest.View
{
	/// <summary>
	/// エクセルデータ
	/// </summary>
	public class ExcelData : IExcelView
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
		/// 新規作成
		/// </summary>
		/// <param name="filePath">ファイルパス</param>
		public void Create(string filePath)
		{
			if (File.Exists(filePath))
			{
				File.Delete(filePath);
			}
			var file = File.Create(filePath);
			package = new ExcelPackage(file);
			worksheet = package.Workbook.Worksheets.Add("sheet1");
		}

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

		public void Save()
		{
			package.Save();
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
		/// テキストデータ取得
		/// </summary>
		/// <param name="row">行</param>
		/// <param name="column">列</param>
		/// <returns>テキストデータ</returns>
		public TextData GetText(int row, int column)
		{
			var value = worksheet.Cells[row, column];
			TextData data = new TextData(new Matrix() { row = row, column = column }, (string)value.Value);
			return data;
		}

		/// <summary>
		/// テキストデータ設定
		/// </summary>
		/// <param name="data">データ</param>
		public void SetText(TextData data)
		{
			worksheet.Cells[data.Location.row, data.Location.column].Value = data.Value;
		}

		/// <summary>
		/// 図形を取得
		/// </summary>
		/// <param name="name">図形の名前</param>
		/// <returns>図形データ</returns>
		public ShapeData GetShape(string name)
		{
			var shape = worksheet.Drawings[name] as ExcelShape;
			ShapeData data = new ShapeData(shape);
			return data;
		}

		/// <summary>
		/// 図形を追加
		/// </summary>
		/// <param name="data">図形データ</param>
		public void AddShape(ShapeData data)
		{
			worksheet.Drawings.AddShape(data.Name, data.Shape);
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

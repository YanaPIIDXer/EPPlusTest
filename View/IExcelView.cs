using System;
using System.Collections.Generic;
using System.Text;

namespace EPPlusTest.View
{
	/// <summary>
	/// Excelのビューインタフェース
	/// </summary>
	public interface IExcelView : IDisposable
	{
		/// <summary>
		/// 新規作成
		/// </summary>
		/// <param name="filePath">ファイルパス</param>
		public void Create(string filePath);

		/// <summary>
		/// 読み込み
		/// </summary>
		/// <param name="filePath">ファイルパス</param>
		public void Load(string filePath);

		/// <summary>
		/// 保存
		/// </summary>
		public void Save();

		/// <summary>
		/// テキストデータ取得
		/// </summary>
		/// <param name="row">行</param>
		/// <param name="column">列</param>
		/// <returns>テキストデータ</returns>
		TextData GetText(int row, int column);

		/// <summary>
		/// テキストデータ設定
		/// </summary>
		/// <param name="data">データ</param>
		void SetText(TextData data);

		/// <summary>
		/// 図形を取得
		/// </summary>
		/// <param name="name">図形の名前</param>
		/// <returns>図形データ</returns>
		ShapeData GetShape(string name);

		/// <summary>
		/// 図形を追加
		/// </summary>
		/// <param name="data">図形データ</param>
		void AddShape(ShapeData data);
	}
}

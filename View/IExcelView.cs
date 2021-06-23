using System;
using System.Collections.Generic;
using System.Text;

namespace EPPlusTest.View
{
	/// <summary>
	/// Excelのビューインタフェース
	/// </summary>
	public interface IExcelView
	{
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
	}
}

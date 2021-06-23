using System;
using System.Collections.Generic;
using System.Text;

namespace EPPlusTest.Model
{
	/// <summary>
	/// テキストデータ
	/// </summary>
	public class TextData : CellData<string>
	{
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public TextData()
		{
			Value = "";
		}

		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="location">座標</param>
		/// <param name="value">値</param>
		public TextData(Matrix location, string value)
			: base(location, value)
		{
		}
	}
}

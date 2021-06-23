using System;
using System.Collections.Generic;
using System.Text;

namespace EPPlusTest
{
	/// <summary>
	/// 図形データ
	/// </summary>
	public class ShapeData : IVectorLocation
	{
		/// <summary>
		/// 位置
		/// </summary>
		public Vector Location { get; set; }

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public ShapeData()
		{
		}
	}
}

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
		/// 名前
		/// </summary>
		public string Name { get; private set; }

		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="name">名前</param>
		public ShapeData(string name)
		{
			Name = name;
		}
	}
}

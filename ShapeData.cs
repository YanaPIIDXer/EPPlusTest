using System;
using System.Collections.Generic;
using System.Text;
using OfficeOpenXml.Drawing;

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
		public string Name { get { return Shape.Name; } }

		/// <summary>
		/// シェイプ
		/// </summary>
		public ExcelShape Shape { get; private set; }

		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="location">座標</param>
		/// <param name="shape">シェイプオブジェクト</param>
		public ShapeData(Vector location, ExcelShape shape)
		{
			Location = location;
			Shape = shape;
		}
	}
}

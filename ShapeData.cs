using System;
using System.Collections.Generic;
using System.Text;
using OfficeOpenXml.Drawing;

namespace EPPlusTest
{
	/// <summary>
	/// 図形データ
	/// </summary>
	public class ShapeData : IRectLocation
	{
		/// <summary>
		/// 位置
		/// </summary>
		public Rect Location { get; set; }

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
		public ShapeData(ExcelShape shape)
		{
			Location = new Rect()
			{
				top = shape.From.Row,
				bottom = shape.To.Row,
				left = shape.From.Column,
				right = shape.To.Column
			};
			Shape = shape;
		}
	}
}

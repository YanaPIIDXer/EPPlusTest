﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EPPlusTest.Model
{
	public class CellData<T> : IMatrixLocation
	{
		/// <summary>
		/// 位置情報
		/// </summary>
		public Matrix Location { get; set; }

		/// <summary>
		/// 値
		/// </summary>
		public T Value { get; set; }

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public CellData()
		{
			Location = new Matrix { row = 1, column = 1 };
		}

		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="location">座標</param>
		/// <param name="value">値</param>
		public CellData(Matrix location, T value)
		{
			Location = location;
			Value = value;
		}
	}
}

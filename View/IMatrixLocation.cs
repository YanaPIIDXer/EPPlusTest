using System;
using System.Collections.Generic;
using System.Text;

namespace EPPlusTest.View
{
	/// <summary>
	/// 行列
	/// </summary>
	public struct Matrix
	{
		/// <summary>
		/// 行
		/// </summary>
		public int row;

		/// <summary>
		/// 列
		/// </summary>
		public int column;
	}

	/// <summary>
	/// 行列の位置情報
	/// </summary>
	public interface IMatrixLocation : ILocation<Matrix>
	{
		public new Matrix Location { get; set; }
	}
}

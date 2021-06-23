using System;
using System.Collections.Generic;
using System.Text;

namespace EPPlusTest.Model
{
	/// <summary>
	/// 位置のスワップ
	/// </summary>
	public class Swapper
	{
		/// <summary>
		/// 位置
		/// </summary>
		private IMatrixLocation location = null;

		public Swapper(IMatrixLocation location)
		{
			this.location = location;
		}

		public void Swap()
		{
			location.Swap();
		}
	}

	/// <summary>
	/// 拡張メソッドの定義
	/// </summary>
	public static class Extensions
	{
		/// <summary>
		/// 行列の入れ替え
		/// </summary>
		public static void Swap(this IMatrixLocation matrix)
		{
			var newMatrix = new Matrix()
			{
				row = matrix.Location.column,
				column = matrix.Location.row
			};
			matrix.Location = newMatrix;
		}
	}
}

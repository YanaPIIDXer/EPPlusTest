using System;
using System.Collections.Generic;
using System.Text;

namespace EPPlusTest.Model
{
	/// <summary>
	/// 行列のスワップ
	/// </summary>
	public class MatrixSwapper
	{
		/// <summary>
		/// 位置
		/// </summary>
		private IMatrixLocation location = null;

		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="location">位置</param>
		public MatrixSwapper(IMatrixLocation location)
		{
			this.location = location;
		}

		/// <summary>
		/// スワップ
		/// </summary>
		public void Swap()
		{
			location.Swap();
		}
	}

	/// <summary>
	/// 矩形のスワップ
	/// </summary>
	public class RectSwapper
	{
		/// <summary>
		/// 位置
		/// </summary>
		private IRectLocation location = null;

		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="location">位置</param>
		public RectSwapper(IRectLocation location)
		{
			this.location = location;
		}

		/// <summary>
		/// スワップ
		/// </summary>
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

		/// <summary>
		/// 矩形の入れ替え
		/// </summary>
		public static void Swap(this IRectLocation rect)
		{
			var newRect = new Rect()
			{
				top = rect.Location.left,
				bottom = rect.Location.right,
				left = rect.Location.top,
				right = rect.Location.bottom
			};
			rect.Location = newRect;
		}
	}
}

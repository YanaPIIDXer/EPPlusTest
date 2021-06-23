using System;
using System.Collections.Generic;
using System.Text;

namespace EPPlusTest
{
	/// <summary>
	/// 矩形
	/// </summary>
	public struct Rect
	{
		/// <summary>
		/// 上
		/// </summary>
		public int top;

		/// <summary>
		/// 下
		/// </summary>
		public int bottom;

		/// <summary>
		/// 左
		/// </summary>
		public int left;

		/// <summary>
		/// 右
		/// </summary>
		public int right;
	}
	/// <summary>
	/// 矩形座標情報
	/// </summary>
	public interface IRectLocation : ILocation<Rect>
	{
		/// <summary>
		/// 座標
		/// </summary>
		public new Rect Location { get; set; }
	}
}

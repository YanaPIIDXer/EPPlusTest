using System;
using System.Collections.Generic;
using System.Text;

namespace EPPlusTest
{
	/// <summary>
	/// ベクトル
	/// </summary>
	public struct Vector
	{
		/// <summary>
		/// X
		/// </summary>
		public int x;

		/// <summary>
		/// Y
		/// </summary>
		public int y;
	}

	/// <summary>
	/// ベクトルの位置情報
	/// </summary>
	public interface IVectorLocation : ILocation<Vector>
	{
		public new Vector Location { get; set; }
	}
}

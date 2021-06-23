using System;
using System.Collections.Generic;
using System.Text;

namespace EPPlusTest
{
	/// <summary>
	/// 位置情報インタフェース
	/// </summary>
	/// <typeparam name="T">位置情報を表す型</typeparam>
	public interface ILocation<T>
	{
		/// <summary>
		/// 位置情報
		/// </summary>
		T Location { get; set; }
	}
}

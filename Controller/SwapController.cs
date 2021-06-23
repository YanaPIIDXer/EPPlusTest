using System;
using System.Collections.Generic;
using System.Text;
using EPPlusTest.View;
using EPPlusTest.Model;

namespace EPPlusTest.Controller
{
	/// <summary>
	/// 行列の入れ替えコントローラ
	/// </summary>
	public class SwapController
	{
		/// <summary>
		/// 入力
		/// </summary>
		private IExcelView srcView = null;

		/// <summary>
		/// 出力
		/// </summary>
		private IExcelView destView = null;

		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="srcView">入力</param>
		/// <param name="destView">出力</param>
		public SwapController(IExcelView srcView, IExcelView destView)
		{
			this.srcView = srcView;
			this.destView = destView;
		}

		/// <summary>
		/// スワップ実行
		/// </summary>
		public void Swap()
		{
			for (int i = 1; i <= 3; i++)
			{
				var data = srcView.GetText(i, 1);
				var swapper = new MatrixSwapper
					(data);
				swapper.Swap();
				destView.SetText(data);
			}

			var shapeData = srcView.GetShape(0);
			var shapeSwapper = new RectSwapper(shapeData);
			shapeSwapper.Swap();
			destView.AddShape(shapeData);

			destView.Save();
		}
	}
}

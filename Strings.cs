using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GARTE.TypeHandling
{
	public static class Strings
	{
		public static string concatStrings(object pv_strStringA, object pv_strStringB, string pv_strSeparator)
		{
			string strA = Base.convertString(pv_strStringA);
			string strB;

			if (strA.Length < 1) return Base.convertString(pv_strStringB);

			strB = Base.convertString(pv_strStringB);

			if (strB.Length > 0) strA += pv_strSeparator + pv_strStringB;

			return strA;
		}
	}
}

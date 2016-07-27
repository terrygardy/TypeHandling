using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GARTE.TypeHandling
{
	public static class Base
	{
		private static DateTime m_datNULL = new DateTime(1753, 1, 1);
		private static TimeSpan m_tsNULL = new TimeSpan(0, 0, 0, 0, 0);

		#region String
		public static string convertString(object pv_objValue)
		{
			return convertString(pv_objValue, "", true);
		}

		public static string convertString(object pv_objValue, string pv_strAlternative)
		{
			return convertString(pv_objValue, pv_strAlternative, true);
		}

		public static string convertString(object pv_objValue, string pv_strAlternative, bool pv_blnTrim)
		{
			string strValue;

			try
			{
				strValue = Convert.ToString(pv_objValue);

				if (pv_blnTrim) strValue = strValue.Trim();
			}
			catch
			{
				strValue = pv_strAlternative;
			}

			return strValue;
		}
		#endregion

		#region Integer
		public static int convertInt(object pv_objValue)
		{
			return convertInt(pv_objValue, 0);
		}

		public static int convertInt(object pv_objValue, int pv_intAlternative)
		{
			int intValue;

			try
			{
				intValue = Convert.ToInt32(pv_objValue);
			}
			catch
			{
				intValue = pv_intAlternative;
			}

			return intValue;
		}
		#endregion

		#region Long
		public static long convertLong(object pv_objValue)
		{
			return convertLong(pv_objValue, 0);
		}

		public static long convertLong(object pv_objValue, long pv_lngAlternative)
		{
			long lngValue;

			try
			{
				lngValue = Convert.ToInt64(pv_objValue);
			}
			catch
			{
				lngValue = pv_lngAlternative;
			}

			return lngValue;
		}
		#endregion

		#region Decimal
		public static decimal convertDec(object pv_objValue)
		{
			return convertDec(pv_objValue, 0);
		}

		public static decimal convertDec(object pv_objValue, decimal pv_decAlternative)
		{
			decimal decValue;

			try
			{
				decValue = Convert.ToDecimal(pv_objValue);
			}
			catch
			{
				decValue = pv_decAlternative;
			}

			return decValue;
		}
		#endregion

		#region Boolean
		public static bool convertBool(object pv_objValue)
		{
			return convertBool(pv_objValue, false);
		}

		public static bool convertBool(object pv_objValue, bool pv_blnAlternative)
		{
			bool blnValue;

			try
			{
				blnValue = Convert.ToBoolean(pv_objValue);
			}
			catch
			{
				blnValue = pv_blnAlternative;
			}

			return blnValue;
		}
		#endregion

		#region Date
		public static DateTime convertDate(object pv_objValue)
		{
			return convertDate(pv_objValue, m_datNULL);
		}

		public static DateTime convertDate(object pv_objValue, DateTime pv_datAlternative)
		{
			DateTime datValue;

			try
			{
				datValue = Convert.ToDateTime(pv_objValue);
			}
			catch
			{
				datValue = pv_datAlternative;
			}

			return datValue;
		}

		public static string convertShortDateString(object pv_objValue)
		{
			return convertShortDateString(pv_objValue, "");
		}

		public static string convertShortDateString(object pv_objValue, string pv_strAlternative)
		{
			DateTime datValue = convertDate(pv_objValue);

			if (datValue <= m_datNULL) return pv_strAlternative;

			return datValue.ToShortDateString();
		}
		#endregion

		#region Time
		public static TimeSpan convertTime(object pv_objValue)
		{
			return convertTime(pv_objValue, m_tsNULL);
		}

		public static TimeSpan convertTime(object pv_objValue, TimeSpan pv_tsAlternative)
		{
			DateTime datValue = convertDate(pv_objValue);

			if (datValue <= m_datNULL) return pv_tsAlternative;

			return new TimeSpan(datValue.Hour, datValue.Minute, datValue.Second, datValue.Millisecond);
		}
		#endregion
	}
}
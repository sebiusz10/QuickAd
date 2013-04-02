using System;
using System.Collections.Generic;
namespace QuickAd.Models
{
	public class DBHelper {
		public static List<T> GetAll<T>() {
			throw new System.Exception("Not implemented");
		}
		public static T FindOne<T>(int id) {
			throw new System.Exception("Not implemented");
		}
		public static void SaveOrUpdate(Object obj) {
			throw new System.Exception("Not implemented");
		}
		public static void Delete(Object obj) {
			throw new System.Exception("Not implemented");
		}

	    public static string generateHash()
	    {
	        byte[] bytes;
            Random r = new Random();
	        String dateStamp = r.NextDouble().ToString() + DateTime.Now.ToString("s") + "hashedExtra";
            bytes = new byte[dateStamp.Length];
	        char[] chars = dateStamp.ToCharArray();
            for(int i=0;i<dateStamp.Length;i++)
            {
                bytes[i] = (byte) chars[i] ;
            }
	        return System.Security.Cryptography.MD5.Create().ComputeHash(bytes).ToString();
	    }
	}

}

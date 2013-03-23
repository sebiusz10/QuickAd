using System;
namespace Schemat obiektów logicznych {
	public class SessionFactory {
		private static readonly string connectionString;
		private static NHibernate.ISessionFactory sFactory;

		private static void Init() {
			throw new System.Exception("Not implemented");
		}
		private static NHibernate.ISessionFactory GetSessionFactory() {
			throw new System.Exception("Not implemented");
		}
		public static Nhibarnate.ISession GetNewSession() {
			throw new System.Exception("Not implemented");
		}

	}

}

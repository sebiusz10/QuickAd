using System;
namespace Schemat obiektów logicznych {
	public class AdvertCategory {
		private int id;
		private String hash;
		private String name;

		public int GetId() {
			return this.id;
		}
		public void SetId(out int id) {
			this.id = id;
		}
		public String GetHash() {
			return this.hash;
		}
		public void SetHash(out String hash) {
			this.hash = hash;
		}
		public String GetName() {
			return this.name;
		}
		public void SetName(out String name) {
			this.name = name;
		}

		private Advertise advertise;

	}

}

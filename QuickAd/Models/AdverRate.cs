using System;
namespace Schemat obiektów logicznych {
	public class AdverRate {
		private int id;
		private String hash;
		private int rate;

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
		public int GetRate() {
			return this.rate;
		}
		public void SetRate(out int rate) {
			this.rate = rate;
		}

		private Advertise advertise;

	}

}

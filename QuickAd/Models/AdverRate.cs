using System;
namespace QuickAd.Models {
	public class AdverRate {
		private int id;
		private String hash;
		private int rate;

		public int GetId() {
			return this.id;
		}
		public void SetId(int id) {
			this.id = id;
		}
		public String GetHash() {
			return this.hash;
		}
		public void SetHash(String hash) {
			this.hash = hash;
		}
		public int GetRate() {
			return this.rate;
		}
		public void SetRate(int rate) {
			this.rate = rate;
		}

		private Advertise advertise;

	}

}

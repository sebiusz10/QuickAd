using System;
namespace QuickAd.Models {
	public class AdvertRate {
		public int Id;
		public String Hash;
		public int Rate;

		public int GetId() {
			return this.Id;
		}
		public void SetId(int id) {
			this.Id = id;
		}
		public String GetHash() {
			return this.Hash;
		}
		public void SetHash(String hash) {
			this.Hash = hash;
		}
		public int GetRate() {
			return this.Rate;
		}
		public void SetRate(int rate) {
			this.Rate = rate;
		}

		private Advertise advertise;

	}

}

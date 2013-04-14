using System;
namespace QuickAd.Models {
	public class AdvertRate {
		private int id;
		private String hash;
		private int rate;
	    private int id_advertise;

        public virtual int Vid { get { return this.id; } set { this.id = value; } }
        public virtual int Vrate { get { return this.rate; } set { this.rate = value; } }
        public virtual int VidAdvertise { get { return this.id_advertise; } set { this.id_advertise = value; } }

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

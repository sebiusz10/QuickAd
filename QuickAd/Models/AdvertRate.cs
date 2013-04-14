using System;
namespace QuickAd.Models 
{
	public class AdvertRate 
    {
		private int Id;
		private String Hash;
		private int Rate;
	    private int IdAdvertise;

        #region ORM Properties

        public virtual int Vid { get { return this.Id; } set { this.Id = value; } }
        public virtual int Vrate { get { return this.Rate; } set { this.Rate = value; } }
        public virtual int VidAdvertise { get { return this.IdAdvertise; } set { this.IdAdvertise = value; } }

        #endregion

        #region Properties

        public int GetId() {return this.Id;}
		public void SetId(int id) {this.Id = id;}

		public String GetHash() {return this.Hash;}
        public void SetHash(String hash) {this.Hash = hash;}

		public int GetRate() {return this.Rate;}
		public void SetRate(int rate) {this.Rate = rate;}

        #endregion

        private Advertise advertise;
	}
}

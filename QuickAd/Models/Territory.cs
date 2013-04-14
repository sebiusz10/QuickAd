using System;
namespace QuickAd.Models 
{
	public class Territory 
    {
        private int Id;
        private String Hash;
        private String Name;

        #region ORM Properties

        public virtual int Vid { get { return this.Id; } set { this.Id = value; } }
        public virtual string Vname { get { return this.Name; } set { this.Name = value; } }

        #endregion

        #region Properties

        public int GetId() {return this.Id;}
		public void SetId(int id) {this.Id = id;}

		public String GetHash() {return this.Hash;}
		public void SetHash(String hash) {this.Hash = hash;}

		public String GetName() {return this.Name;}
		public void SetName(String name){this.Name = name;}

        #endregion
    }
}

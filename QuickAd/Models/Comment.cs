using System;
namespace QuickAd.Models
{
	public class Comment 
    {
        private int Id;
        private String Hash;
        private String Title;
        private String Content;
        private DateTime CreatedAt;
        private int IdAdvert;

        #region ORM Properties

        public virtual int Vid { get { return this.Id; } set { this.Id = value; } }
        public virtual string Vtitle {get { return this.Title; } set { this.Title = value; }}
        public virtual string Vcontent {get {return this.Content;} set { this.Content = value; }}
        public virtual DateTime VcreatedDate {get { return this.CreatedAt; } set { this.CreatedAt = value; }}
        public virtual int VidAdvertise {get { return this.IdAdvert; } set { this.IdAdvert = value; }}

        #endregion

        #region Properties

        public int GetId() {return this.Id;}
		public void SetId(int id) {this.Id = id;}

		public String GetHash() {return this.Hash;}
		public void SetHash(String hash) {this.Hash = hash;}

		public String GetTitle() {return this.Title;}
		public void SetTitle(String title) {this.Title = title;}

		public String GetContent() {return this.Content;}
		public void SetContent(String content) {this.Content = content;}

		public DateTime GetCreatedAt() {return this.CreatedAt;}
		public void SetCreatedAt(DateTime createdAt) {this.CreatedAt = createdAt;}

        #endregion
    }
}

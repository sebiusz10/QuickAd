using System;
namespace QuickAd.Models 
{
	public class Advertise 
    {
		private String Title;
		private String Content;
		private DateTime Validity;
        private int Visits;
        private double Price;
        private String AddinationalInfo;
        private bool VisibleToOthers;
        private String Hash;
        private int Id;
        private int IdUser;
        private int IdAdvertCategory;
        private int IdTerritory;

        #region ORM Properties

        public virtual int Vint {get { return this.Id; } set { this.Id = value; }}
        public virtual string Vtitle {get { return this.Title; } set { this.Title = value; }}
        public virtual int VidUser {get { return this.IdUser; } set { this.IdUser = value; }}
        public virtual string Vcontent {get { return this.Content; } set { this.Content = value; }}
        public virtual DateTime Vvalidity {get { return this.Validity; } set { this.Validity = value; }}
        public virtual int Vvisits {get { return this.Visits; } set { this.Visits = value; }}
        public virtual double Vprice {get { return this.Price; } set { this.Price = value; }}
        public virtual string VadditionalInfo {get { return this.AddinationalInfo; } set { this.AddinationalInfo = value; }}
        public virtual bool VvisibleToOthers {get { return this.VisibleToOthers; } set { this.VisibleToOthers = value; }}
        public virtual int VidAdvertCategry {get { return this.IdAdvertCategory; } set { this.IdAdvertCategory = value; }}
        public virtual int VidIdTerritory {get { return this.IdTerritory; } set { this.IdTerritory = value; }}

        #endregion

        #region Properties

        public String GetTitle() {return this.Title;}
		public void SetTitle(String title) {this.Title = title;}

		public String GetContent() {return this.Content;}
		public void SetContent(String content) {this.Content = content;}

		public DateTime GetValidity() {return this.Validity;}
		public void SetValidity(DateTime validity) {this.Validity = validity;}

		public int GetVisits() {return this.Visits;}
		public void SetVisits(int visits) {this.Visits = visits;}

		public double GetPrice() {return this.Price;}
		public void SetPrice(double price) {this.Price = price;}

		public String GetAddinationalInfo() {return this.AddinationalInfo;}
		public void SetAddinationalInfo(String addinationalInfo) {this.AddinationalInfo = addinationalInfo;}

		public bool GetVisibleToOthers() {return this.VisibleToOthers;}
		public void SetVisibleToOthers(bool visibleToOthers) {this.VisibleToOthers = visibleToOthers;}

		public String GetHash() {return this.Hash;}
		public void SetHash(String hash) {this.Hash = hash;}

		public int GetId() {return this.Id;}
		public void SetId(int id) {this.Id = id;}

		public AdvertCategory GetCategory() {throw new System.Exception("Not implemented");}
		public void SetAdvertCategory(AdvertCategory advertCat) {throw new System.Exception("Not implemented");}

		public Image[] GetGalleryImages() {throw new System.Exception("Not implemented");}
		public void SetGalleryImages(Image[] galleryImages) {throw new System.Exception("Not implemented");}

        public void GetAttribute() {throw new System.Exception("Not implemented");}
        public void SetAttribute(int attribute) {throw new System.Exception("Not implemented");}

        #endregion

        public void AddGalleryImage(Image img)
        {
			throw new System.Exception("Not implemented");
		}

		public void DeleteAllGalleryImages() 
        {
			throw new System.Exception("Not implemented");
		}

		public void IncrementVisitsCount()
        {
			throw new System.Exception("Not implemented");
		}

        private Advertise advertise2;
		private AdvertCategory advertCategory;
		private Territory teritory;
		private Comment[] comments;
		private Image[] images;
		private Image image;

		private Advertise advertise;

	}

}

using System;
namespace QuickAd.Models {
	public class Advertise {
		public String Title;
		public String Content;
		public DateTime Validity;
		public int Visits;
		public double Price;
		public String AddinationalInfo;
		public bool VisibleToOthers;
		public String Hash;
		public int Id;

		public String GetTitle() {
			return this.Title;
		}
		public void SetTitle(String title) {
			this.Title = title;
		}
		public String GetContent() {
			return this.Content;
		}
		public void SetContent(String content) {
			this.Content = content;
		}
		public DateTime GetValidity() {
			return this.Validity;
		}
		public void SetValidity(DateTime validity) {
			this.Validity = validity;
		}
		public int GetVisits() {
			return this.Visits;
		}
		public void SetVisits(int visits) {
			this.Visits = visits;
		}
		public double GetPrice() {
			return this.Price;
		}
		public void SetPrice(double price) {
			this.Price = price;
		}
		public String GetAddinationalInfo() {
			return this.AddinationalInfo;
		}
		public void SetAddinationalInfo(String addinationalInfo) {
			this.AddinationalInfo = addinationalInfo;
		}
		public bool GetVisibleToOthers() {
			return this.VisibleToOthers;
		}
		public void SetVisibleToOthers(bool visibleToOthers) {
			this.VisibleToOthers = visibleToOthers;
		}
		public String GetHash() {
			return this.Hash;
		}
		public void SetHash(String hash) {
			this.Hash = hash;
		}
		public int GetId() {
			return this.Id;
		}
		public void SetId(int id) {
			this.Id = id;
		}
		public AdvertCategory GetCategory() {
			throw new System.Exception("Not implemented");
		}
		public void SetAdvertCategory(AdvertCategory advertCat) {
			throw new System.Exception("Not implemented");
		}
		public Image[] GetGalleryImages() {
			throw new System.Exception("Not implemented");
		}
		public void SetGalleryImages(Image[] galleryImages) {
			throw new System.Exception("Not implemented");
		}
		public void AddGalleryImage(Image img) {
			throw new System.Exception("Not implemented");
		}
		public void DeleteAllGalleryImages() {
			throw new System.Exception("Not implemented");
		}
		public void IncrementVisitsCount() {
			throw new System.Exception("Not implemented");
		}
		public GetAttribute() {
			throw new System.Exception("Not implemented");
		}
		public void SetAttribute( attribute) {
			throw new System.Exception("Not implemented");
		}

		private Advertise advertise2;
		private AdvertCategory advertCategory;
		private Teritory teritory;
		private Comment[] comments;
		private Image[] images;
		private Image image;

		private Advertise advertise;

	}

}

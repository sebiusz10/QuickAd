using System;
namespace QuickAd.Models {
	public class Advertise {
		private String title;
		private String content;
		private DateTime validity;
		private int visits;
		private double price;
		private String addinationalInfo;
		private bool visibleToOthers;
		private int id;
		private String hash;

		public String GetTitle() {
			return this.title;
		}
		public void SetTitle(String title) {
			this.title = title;
		}
		public String GetContent() {
			return this.content;
		}
		public void SetContent(String content) {
			this.content = content;
		}
		public DateTime GetValidity() {
			return this.validity;
		}
		public void SetValidity(DateTime validity) {
			this.validity = validity;
		}
		public int GetVisits() {
			return this.visits;
		}
		public void SetVisits(int visits) {
			this.visits = visits;
		}
		public double GetPrice() {
			return this.price;
		}
		public void SetPrice(double price) {
			this.price = price;
		}
		public String GetAddinationalInfo() {
			return this.addinationalInfo;
		}
		public void SetAddinationalInfo(String addinationalInfo) {
			this.addinationalInfo = addinationalInfo;
		}
		public bool GetVisibleToOthers() {
			return this.visibleToOthers;
		}
		public void SetVisibleToOthers(bool visibleToOthers) {
			this.visibleToOthers = visibleToOthers;
		}
		public bool IsValid() {
			throw new System.Exception("Not implemented");
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
		public void IncrementVisitisCount() {
			throw new System.Exception("Not implemented");
		}

		private AdvertCategory advertCategory;
		private Image image;
		private Teritory teritory;
		private Image[] images;
		private Comment[] comments;
		private AdverRate[] adverRates;

	}

}

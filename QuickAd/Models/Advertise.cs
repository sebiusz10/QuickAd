using System;
namespace Schemat obiektów logicznych {
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
		public void SetTitle(out String title) {
			this.title = title;
		}
		public String GetContent() {
			return this.content;
		}
		public void SetContent(out String content) {
			this.content = content;
		}
		public DateTime GetValidity() {
			return this.validity;
		}
		public void SetValidity(out DateTime validity) {
			this.validity = validity;
		}
		public int GetVisits() {
			return this.visits;
		}
		public void SetVisits(out int visits) {
			this.visits = visits;
		}
		public double GetPrice() {
			return this.price;
		}
		public void SetPrice(out double price) {
			this.price = price;
		}
		public String GetAddinationalInfo() {
			return this.addinationalInfo;
		}
		public void SetAddinationalInfo(out String addinationalInfo) {
			this.addinationalInfo = addinationalInfo;
		}
		public bool GetVisibleToOthers() {
			return this.visibleToOthers;
		}
		public void SetVisibleToOthers(out bool visibleToOthers) {
			this.visibleToOthers = visibleToOthers;
		}
		public bool IsValid() {
			throw new System.Exception("Not implemented");
		}
		public AdvertCategory GetCategory() {
			throw new System.Exception("Not implemented");
		}
		public void SetAdvertCategory(out AdvertCategory advertCat) {
			throw new System.Exception("Not implemented");
		}
		public Image[] GetGalleryImages() {
			throw new System.Exception("Not implemented");
		}
		public void SetGalleryImages(out Image[] galleryImages) {
			throw new System.Exception("Not implemented");
		}
		public void AddGalleryImage(out Image img) {
			throw new System.Exception("Not implemented");
		}
		public void DeleteAllGalleryImages() {
			throw new System.Exception("Not implemented");
		}
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

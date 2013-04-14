using System;
namespace QuickAd.Models {
	public class User {
		public String FirstName;
		public String LastName;
		public String Email;
		public DateTime DateOfBirth;
		public String City;
		public String Street;
		public int BuildingNumber;
		public int HomeNumber;
		public int Sex;
		public String Password;
		public String PhoneNumber;
		public String Hash;
		public int Privillage;
		public int Id;

		public String GetFirstName() {
			return this.FirstName;
		}
		public void SetFirstName(String firstName) {
			this.FirstName = firstName;
		}
		public String GetLastName() {
			return this.LastName;
		}
		public void SetLastName(String lastName) {
			this.LastName = lastName;
		}
		public String GetEmail() {
			return this.Email;
		}
		public void SetEmail(String email) {
			this.Email = email;
		}
		public DateTime GetDateOfBirth() {
			return this.DateOfBirth;
		}
		public void SetDateOfBirth(DateTime dateOfBirth) {
			this.DateOfBirth = dateOfBirth;
		}
		public String GetCity() {
			return this.City;
		}
		public void SetCity(String city) {
			this.City = city;
		}
		public String GetStreet() {
			return this.Street;
		}
		public void SetStreet(String street) {
			this.Street = street;
		}
		public int GetBuildingNumber() {
			return this.BuildingNumber;
		}
		public void SetBuildingNumber(int buildingNumber) {
			this.BuildingNumber = buildingNumber;
		}
		public GetAttribute() {
			throw new System.Exception("Not implemented");
		}
		public void SetAttribute( attribute) {
			throw new System.Exception("Not implemented");
		}
		public int GetHomeNumber() {
			return this.HomeNumber;
		}
		public void SetHomeNumber(int homeNumber) {
			this.HomeNumber = homeNumber;
		}
		public int GetSex() {
			return this.Sex;
		}
		public void SetSex(int sex) {
			this.Sex = sex;
		}
		public String GetPassword() {
			return this.Password;
		}
		public void SetPassword(String password) {
			this.Password = password;
		}
		public String GetPhoneNumber() {
			return this.PhoneNumber;
		}
		public void SetPhoneNumber(String phoneNumber) {
			this.PhoneNumber = phoneNumber;
		}
		public String GetHash() {
			return this.Hash;
		}
		public void SetHash(String hash) {
			this.Hash = hash;
		}
		public int GetPrivillage() {
			return this.Privillage;
		}
		public void SetPrivillage(int privillage) {
			this.Privillage = privillage;
		}
		public bool IsAdmin() {
			throw new System.Exception("Not implemented");
		}
		public void IsOwner(Advertise adv) {
			throw new System.Exception("Not implemented");
		}
		public int GetId() {
			return this.Id;
		}
		public void SetId(int id) {
			this.Id = id;
		}
		public Email CreateEmailTo(User user) {
			throw new System.Exception("Not implemented");
		}

		private Email[] emails;
		private Advertise[] advertises;

	}

}

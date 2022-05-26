class Applicant : IApplicant {
	public Applicant (
		string firstName,
		string lastName,
		string middleName
	) {
		FirstName = firstName;
		LastName = lastName;
		MiddleName = middleName;
	}
	public string FirstName { get; }
	public string LastName { get; }
	public string MiddleName { get; }
}

interface IApplicationForm : ITemporal {
	IApplicant Applicant { get; }
	string Body { get; }
	string ToString();
}

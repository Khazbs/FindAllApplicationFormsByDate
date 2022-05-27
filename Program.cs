using System;

class Program {
	public static void Main(string[] args) {
		var applicationService = ApplicationService.Instance;

		IApplicant john = new Applicant("John", "Michael", "Doe");
		IApplicant jane = new Applicant("Jane", "Emily", "Doe");

		applicationService.CreateApplication(john,
			"Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do"
			+ " eiusmod tempor incididunt ut labore et dolore magna aliqua.",
			new DateTime(2022, 5, 25, 12, 0, 0)
		);
		applicationService.CreateApplication(jane,
			"Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris"
			+ " nisi ut aliquip ex ea commodo consequat.",
			new DateTime(2022, 5, 25, 18, 0, 0)
		);
		applicationService.CreateApplication(john,
			"Duis aute irure dolor in reprehenderit in voluptate velit esse cillum"
			+ " dolore eu fugiat nulla pariatur.",
			new DateTime(2022, 5, 26, 12, 0, 0)
		);
		applicationService.CreateApplication(jane,
			"Excepteur sint occaecat cupidatat non proident, sunt in culpa qui"
			+ " officia deserunt mollit anim id est laborum.",
			new DateTime(2022, 5, 26, 18, 0, 0)
		);

		var may25 = new DateTime(2022, 5, 25);
		var may26 = new DateTime(2022, 5, 26);
		
		var may25Applications = applicationService.FindApplicationsByDate(may25);
		var may26Applications = applicationService.FindApplicationsByDate(may26);

		Console.WriteLine(may25.ToString("===== dd MMMM yyyy, dddd =====\n"));
		foreach (var application in may25Applications) {
			Console.WriteLine(application.ToString());
		}
		Console.WriteLine(may26.ToString("===== dd MMMM yyyy, dddd =====\n"));
		foreach (var application in may26Applications) {
			Console.WriteLine(application.ToString());
		}
	}
}

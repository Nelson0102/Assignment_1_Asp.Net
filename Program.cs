using Assignment_1_Asp.Net;

namespace Assignment_1_Asp_Net
{
    internal class Program
    {
        public static void Main()
        {
            // Prompting the user to enter the age of the patient
            Console.WriteLine("Please enter the age of the patient:");
            // Reading the user's input and converting it to an integer
            int age = Convert.ToInt32(Console.ReadLine());

            // Prompting the user to enter the patient's information
            Console.WriteLine("Please enter the patient's information:");

            // Prompting the user to enter the first name of the patient
            Console.Write("First Name of the patient: ");
            // Reading the user's input and storing it in the 'firstName' variable
            string firstName = Console.ReadLine();

            // Prompting the user to enter the last name of the patient
            Console.Write("Last Name of the patient: ");
            // Reading the user's input and storing it in the 'lastName' variable
            string lastName = Console.ReadLine();

            // Prompting the user to enter the weight of the patient in kilograms
            Console.Write("Weight of the patient in kilograms (in KG): ");
            // Reading the user's input and converting it to a double
            double weight = Convert.ToDouble(Console.ReadLine());

            // Prompting the user to enter the height of the patient in centimeters
            Console.Write("Height of the patient in centimeters (in CM): ");
            // Reading the user's input and converting it to a double
            double height = Convert.ToDouble(Console.ReadLine());

            // Creating a new instance of the 'Patient' class using the provided information
            Patient patient = new Patient(firstName, lastName, weight, height);

            // Displaying the heading for the patient's information
            Console.WriteLine("Patient Information:");
            // Retrieving and displaying the patient's information using the 'GetPatientInformation' method
            Console.WriteLine(patient.GetPatientInformation());

            // Waiting for the user to press Enter before closing the application
            Console.ReadLine();
        }
    }
}

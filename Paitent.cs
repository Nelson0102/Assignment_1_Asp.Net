using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment_1_Asp.Net
{
    public class Patient
    {
        private string firstName; // Stores the first name of the patient
        private string lastName; // Stores the last name of the patient
        private double weight; // Stores the weight of the patient in kilograms
        private double height; // Stores the height of the patient in centimeters

        // Constructor to initialize the patient object with the provided information
        public Patient(string firstName, string lastName, double weight, double height)
        {
            this.firstName = firstName; // Assigning the value of the 'firstName' parameter to the firstName field
            this.lastName = lastName; // Assigning the value of the 'lastName' parameter to the lastName field
            this.weight = weight; // Assigning the value of the 'weight' parameter to the weight field
            this.height = height; // Assigning the value of the 'height' parameter to the height field
        }

        public string FirstName
        {
            get { return firstName; } // Getter to retrieve the value of the firstName field
            set { firstName = value; } // Setter to set the value of the firstName field
        }

        public string LastName
        {
            get { return lastName; } // Getter to retrieve the value of the lastName field
            set { lastName = value; } // Setter to set the value of the lastName field
        }

        public double Weight
        {
            get { return weight; } // Getter to retrieve the value of the weight field
            set { weight = value; } // Setter to set the value of the weight field
        }

        public double Height
        {
            get { return height; } // Getter to retrieve the value of the height field
            set { height = value; } // Setter to set the value of the height field
        }

        // Method to calculate the patient's blood pressure category based on the provided systolic and diastolic values
        public string CalculateBloodPressure(int systolic, int diastolic)
        {
            // Checking if either systolic or diastolic values are negative
            if (systolic < 0 || diastolic < 0)
            {
                return "Invalid blood pressure values."; // Return an error message for invalid values
            }
            // Checking if both systolic and diastolic values are within the normal range
            else if (systolic < 120 && diastolic < 80)
            {
                return "Normal blood pressure"; // Returning "Normal blood pressure" if blood pressure is normal
            }
            // Checking if systolic value is slightly elevated and diastolic value is within the normal range
            else if (systolic < 130 && diastolic < 80)
            {
                return "Elevated blood pressure"; // Returning "Elevated blood pressure" if blood pressure is slightly elevated
            }
            // Checking if systolic value is in stage 1 hypertension range or diastolic value is in stage 1 hypertension range
            else if (systolic < 140 || diastolic < 90)
            {
                return "High blood pressure (Hypertension) - Stage 1"; // Returning stage 1 hypertension message
            }
            // Checking if systolic value is in stage 2 hypertension range or diastolic value is in stage 2 hypertension range
            else if (systolic < 180 || diastolic < 120)
            {
                return "High blood pressure (Hypertension) - Stage 2"; // Returning stage 2 hypertension message
            }
            else
            {
                return "Hypertensive crisis (Consult your doctor immediately)"; // Returning hypertensive crisis message
            }
        }

        // Method to calculate the Body Mass Index (BMI) of the patient
        public double CalculateBMI()
        {
            double heightInMeters = height / 100; // Convert height from centimeters to meters
            return weight / (heightInMeters * heightInMeters); // Calculate the BMI using the weight and height
        }

        // Method to get the patient's information including blood pressure category, BMI, and BMI status
        public string GetPatientInformation()
        {
            // Calculating the blood pressure category using default values of 120 for systolic and 80 for diastolic
            string bloodPressureCategory = CalculateBloodPressure(120, 80); // Assuming default values

            // Calculating the BMI using the CalculateBMI method
            double bmi = CalculateBMI();

            // Determining the BMI status based on the calculated BMI value
            string bmiStatus;
            if (bmi >= 25.0)
            {
                bmiStatus = "Overweight";
            }
            else if (bmi >= 18.5)
            {
                bmiStatus = "Normal (In the healthy range)";
            }
            else
            {
                bmiStatus = "Underweight";
            }

            // Constructing the patient information string using the retrieved values
            string patientInformation = $"Full Name: {firstName} {lastName}\n" +
                                        $"Weight: {weight} KG\n" +
                                        $"Height: {height} CM\n" +
                                        $"Blood Pressure: {bloodPressureCategory}\n" +
                                        $"BMI: {bmi}\n" +
                                        $"BMI Status: {bmiStatus}";

            return patientInformation; // Return the patient information string
        }
    }
}


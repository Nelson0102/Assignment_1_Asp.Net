using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Asp_Net
{
    public class Patient
    {
        private string firstName; // Private variable to store the first name of the patient
        private string lastName; // Private variable to store the last name of the patient
        private double weight; // Private variable to store the weight of the patient
        private double height; // Private variable to store the height of the patient

        // Constructor to initialize the patient object with the provided information
        public Patient(string firstName, string lastName, double weight, double height)
        {
            FirstName = firstName; // Assigning the value of the 'firstName' parameter to the FirstName property
            LastName = lastName; // Assigning the value of the 'lastName' parameter to the LastName property
            Weight = weight; // Assigning the value of the 'weight' parameter to the Weight property
            Height = height; // Assigning the value of the 'height' parameter to the Height property
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

        public string CalculateBP(int systolic, int diastolic)
        {
            // Checking if either systolic or diastolic values are negative
            if (systolic < 0 || diastolic < 0)
            {
                return "Invalid blood pressure values."; // Return an error message for invalid values
            }
            // Checking if both systolic and diastolic values are within the normal range
            else if (systolic < 120 && diastolic < 80)
            {
                return "NORMAL"; // Returning "NORMAL" if blood pressure is normal
            }
            // Checking if systolic value is slightly elevated and diastolic value is within the normal range
            else if (systolic < 130 && diastolic < 80)
            {
                return "ELEVATED"; // Returning "ELEVATED" if blood pressure is slightly elevated
            }
            // Checking if systolic value is in stage 1 hypertension range or diastolic value is in stage 1 hypertension range
            else if (systolic < 140 || diastolic < 90)
            {
                return "HIGH BLOOD PRESSURE (HYPERTENSION) STAGE 1"; // Returning stage 1 hypertension message
            }
            // Checking if systolic value is in stage 2 hypertension range or diastolic value is in stage 2 hypertension range
            else if (systolic < 180 || diastolic < 120)
            {
                return "HIGH BLOOD PRESSURE (HYPERTENSION) STAGE 2"; // Returning stage 2 hypertension message
            }
            else
            {
                return "HYPERTENSIVE CRISIS (consult your doctor immediately)"; // Returning hypertensive crisis message
            }
        }


        // Method to calculate the Body Mass Index (BMI) of the patient
        public double CalculateBMI()
        {
            double heightInMeters = Height / 100; // Convert height from centimeters to meters
            return Weight / (heightInMeters * heightInMeters); // Calculate the BMI using the weight and height
        }

        // Method to get the patient's information including blood pressure, BMI, and BMI status
        public string GetPatientInformation()
        {
            // Calculating the blood pressure result using default values of 120 for systolic and 80 for diastolic
            string BPResult = CalculateBP(120, 80); // Assuming default values

            // Calculating the BMI result using the CalculateBMI method
            double bmiResult = CalculateBMI();

            // Declaring a string variable to store the BMI status
            string bmiStatus = "";

            // BMI status based on the calculated BMI result
            if (bmiResult >= 25.0)
            {
                bmiStatus = "Overweight";
            }
            else if (bmiResult >= 18.5)
            {
                bmiStatus = "Normal (In the healthy range)";
            }
            else
            {
                bmiStatus = "Underweight";
            }

            // Construct the patient information string using the retrieved values
            string patientInformation = $"Full Name: {FirstName} {LastName}\n" +
                                        $"Weight: {Weight} KG\n" +
                                        $"Height: {Height} CM\n" +
                                        $"Blood Pressure: {BPResult}\n" +
                                        $"BMI: {bmiResult}\n" +
                                        $"BMI Status: {bmiStatus}";

            return patientInformation; // Return the patient information string
        }

    }
}


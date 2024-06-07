# Assignment -ListView (and all other Skills)

Required:
Header ( Name, Date, Assignment Name )
Submission via Github
Comments
Objective:
Enhance the Student Grades Management System to include a second grade for each student and a method to calculate and display the average grade. Ensure that at least five student names are displayed in a ListView.

Requirements:
User Interface:
Design a user interface using WPF (Windows Presentation Foundation) forms.
The interface should include:
Textboxes for inputting student names, first grade, and second grade.
Buttons for adding, editing, and deleting student records.
A ListView to display the list of students, their grades, and average grade.
Data Handling:
Create a Student class with properties for Name, Grade1, Grade2, and a method GetAverageGrade().
Use a list to store student objects.
Implement methods to add, edit, and delete student records in the list.
Functionality:
Add Student:
Allow users to input a student's name, first grade, and second grade and add this information to the list.
Update the ListView to reflect the new entry.
Edit Student:
Allow users to select a student from the ListView, edit their information, and save the changes.
Update the ListView to reflect the edited entry.
Delete Student:
Allow users to select a student from the ListView and remove them from the list.
Update the ListView to reflect the deletion.
Data Validation:
Ensure that the input for student names is not empty.
Validate that the grade inputs are numbers between 0 and 100.
Display:
Use a ListView to display the list of students, their grades, and average grade in a tabular format.
Ensure that at least five student names are displayed in the ListView.
The ListView should update automatically when new data is added, edited, or deleted.
Updated UML Class Diagram for Student:
+------------------+
|     Student      |
+------------------+
| - name: String   |
| - grade1: Double |
| - grade2: Double |
+------------------+
| + GetAverageGrade(): Double |
+------------------+
Example Layout:
Textboxes:

Student Name: [__]

First Grade: [__]

Second Grade: [__]

Buttons:

[Add Student]

[Edit Selected Student]

[Delete Selected Student]

ListView:

  | Student Name       | Grade 1 | Grade 2 | Average Grade |
  |--------------------|---------|---------|---------------|
  | John Doe           | 85      | 90      | 87.5          |
  | Jane Smith         | 92      | 88      | 90.0          |
  | ...                | ...     | ...     | ...           |
Instructions:
Setup:
Create a new WPF project in Visual Studio.
Design the main window with the required UI elements.
Implementation:
Implement the Student class according to the UML diagram.
Create a list to manage student objects.
Implement the methods for adding, editing, and deleting students.
Bind the ListView to the list of students and include columns for the student name, grades, and average grade.
Ensure Minimum Display:
Add functionality to check that the ListView always displays at least five student records.
If fewer than five records are present, add placeholder records to meet the minimum requirement.
Testing:
Test the application to ensure it meets all requirements and handles edge cases gracefully.
Evaluation Criteria:
Completeness: Does the application meet all the requirements?
Functionality: Does the application correctly handle adding, editing, and deleting student records, and accurately calculate the average grade?
User Interface: Is the interface intuitive and easy to use?
Code Quality: Is the code well-organized and commented?
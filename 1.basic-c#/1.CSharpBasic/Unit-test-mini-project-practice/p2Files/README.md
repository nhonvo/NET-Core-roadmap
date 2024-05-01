## Practice with file
## duration: 180 mins
## allow use internet: YES
## allow discussion: NO
## the code must be commited after time is out. if you have any problem you could noted on the *.md file

### the problems
Exercise: Student Management System with console
-----------------------------------

You need to create a student management system that stores student information such as Name, StudentId, and subject-wise marks obtained. The system should allow the user to perform the following operations:

1.  Add a new student record to the system
2.  Search for a student record by StudentId
3.  Edit an existing student record
4.  Delete an existing student record
5.  Display all student records
6.  Exit the system

Each student record should be stored in a file, and the file name should be the student's StudentId.

You can use the following guidelines to implement the system:

1.  Create a class named `Student` with the following properties: `Name`, `StudentId`, and `SubjectMarks`. The `SubjectMarks` property should be a dictionary where the keys are subject names and the values are the marks obtained by the student in each subject.

2.  Create a class named `StudentManagementSystem` with the following methods:

    -   `AddStudent()`: This method should prompt the user to enter the student's `Name`, `StudentId`, and subject-wise `marks obtained`. It should then create a `Student` object and save the object to a file with the name as the `StudentId`.
    -   `SearchStudent()`: This method should prompt the user to enter a `StudentId` and search for the corresponding file. If the file is found, it should read the data from the file and display the student's information.
    -   `EditStudent()`: This method should prompt the user to enter a `StudentId` and search for the corresponding file. If the file is found, it should allow the user to edit the student's `Name`, `StudentId`, and subject-wise `marks obtained`. It should then save the updated information to the file.
    -   `DeleteStudent()`: This method should prompt the user to enter a `StudentId` and search for the corresponding file. If the file is found, it should delete the file.
    -   `DisplayAllStudents()`: This method should display the information of all students by reading the data from all files.
    -   `ExitSystem()`: This method should exit the system.
3.  In the `main` function, create a `StudentManagementSystem` object and use its methods to perform the operations mentioned above.

4.  Use file I/O functions to read and write data to files.


Enter your choice:

1\. Add a new student record to the system

2\. Search for a student record by StudentId

3\. Edit an existing student record

4\. Delete an existing student record

5\. Display all student records

6\. Exit the system

1

Enter student name: John Doe

Enter student ID: 12345

Enter marks obtained for subject1: 90

Enter marks obtained for subject2: 85

Enter marks obtained for subject3: 92

Student added successfully!

### Check list to self review:
  - [ ] All the function are working as expected
  - [ ] File are split
  - [ ] Write/Read file using async
  - [ ] Catching exception/global exception

### How you rate your score from 1 - 100 on this excercise?
  - answer with number
### What did you do to solve this problem & why you do like that?
  - explain detail what problem come with you while doing to solve this problem and how you overcome it?